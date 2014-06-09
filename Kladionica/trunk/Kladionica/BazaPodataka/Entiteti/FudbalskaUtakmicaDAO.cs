using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kladionica.BazaPodataka
{
    public class FudbalskaUtakmicaDAO : Interfejsi.IDaoCrud<FudbalskaUtakmica>
    {
        protected MySqlCommand c;
        public long create(FudbalskaUtakmica entity)
        {
            try
            {

                DAL.Connection.Open();

                //moguće greške sa smještanjem DATETIME u bazu
                //rijašiti tako da DateTIme konverutjemo u string, a iz stringa u bazi u DateTime
                //Ponude ID nije riješeno kako treba
                string ponuda = "(select max(id) from ponude)";
                c = new MySqlCommand("insert into Igre(Pocetak, StatusIgre, Naziv, IgreType_ID, Ponude_ID)" +
                    " values( '" + entity.Pocetak.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + codeStatus(entity.statusIgre) + "', '" + entity.Naziv + "', " +
                    1 + ", " + ponuda + ")", DAL.Connection);
                c.ExecuteNonQuery();

                long ID = c.LastInsertedId;

                c = new MySqlCommand("insert into FudbalskeUtakmice(ID, Domacin, Gost, PoeniDomacin, PoeniGost)" +
                    " values( " + ID + ", '" + entity.Domacin + "', '" + entity.Gost + "', " +
                    entity.PoeniDomacin + ", " + entity.PoeniGost + ")", DAL.Connection);
                c.ExecuteNonQuery();

                KoeficijentDAO k = DAL.Factory.getKoeficijentDAO();

                DAL.Connection.Close();

                foreach (var item in entity.koeficijenti)
                {
                    
                    k.create(item, ID);
                }
                return ID;


            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                
            }

        }

        private int codeStatus(StatusIgre statusIgre)
        {
            switch (statusIgre)
            {
                case StatusIgre.NijePocela:
                    return 0;
                case StatusIgre.Obustavljena:
                    return 1;
                case StatusIgre.Odgodjena:
                    return 2;
                case StatusIgre.UToku:
                    return 3;
                case StatusIgre.Zavrsena:
                    return 4;
                default:
                    return -1;
            }
        }

        private StatusIgre encodeStatus(int p)
        {
            switch (p)
            {
                case 0:
                    return StatusIgre.NijePocela;
                case 1:
                    return StatusIgre.Obustavljena;
                case 2:
                    return StatusIgre.Odgodjena;
                case 3:
                    return StatusIgre.UToku;
                default:
                    return StatusIgre.Zavrsena;
            }
        }

        public FudbalskaUtakmica read(FudbalskaUtakmica entity)
        {
            return getById(entity.ID);
        }

        public FudbalskaUtakmica update(FudbalskaUtakmica entity)
        {
            try
            {
                DAL.Connection.Open();
                c = new MySqlCommand(String.Format("update Igre set Pocetak={0}, StatusIgre={1}, Naziv={2}, IgreType_ID={3}, Ponude_ID={4} where id={5}",                  
                entity.Pocetak,codeStatus(entity.statusIgre),entity.Naziv,1 ,0, entity.ID), DAL.Connection);
                c.ExecuteNonQuery();

               
                c = new MySqlCommand(String.Format("insert into FudbalskeUtakmice set Domacin={0}, Gost={1}, PoeniDomacin={2}, PoeniGost={3} where id={4})",
                    entity.Domacin, entity.Gost,entity.PoeniDomacin,entity.PoeniGost,entity.ID), DAL.Connection);
                c.ExecuteNonQuery();

                
                return getById(entity.ID);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DAL.Connection.Close();
            }
        }

        public void delete(FudbalskaUtakmica entity)
        {
            try
            {
                DAL.Connection.Open();

                int id = Convert.ToInt32(entity.ID);
                c = new MySqlCommand("delete from Igre where id=" + id, DAL.Connection);
                c.ExecuteNonQuery();

                c = new MySqlCommand("delete from FudbalskeUtakmice where id=" + id, DAL.Connection);
                c.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DAL.Connection.Close();
            }
        }

        public FudbalskaUtakmica getById(int id)
        {
            try
            {
                DAL.Connection.Open();
                
                c = new MySqlCommand("select * from Igre where id=" + id, DAL.Connection);
                MySqlCommand c1  = new MySqlCommand("select * from FudbalskeUtakmice where id=" + id, DAL.Connection);
                MySqlDataReader r = c.ExecuteReader(), r2;

                if (!r.Read()) return null;
                DateTime t = r.GetDateTime("pocetak");
                string naziv = r.GetString("Naziv");
                int ID = r.GetInt32("ID");
                StatusIgre s = encodeStatus(r.GetInt32("StatusIgre"));
                r.Close();

                r2 = c1.ExecuteReader();

                if (r2.Read())
                {

                    FudbalskaUtakmica f = new FudbalskaUtakmica(t, naziv, s, r2.GetString("Domacin"), r2.GetString("Gost"), 
                        r2.GetInt32("PoeniDomacin"), r2.GetInt32("PoeniGost"));

                    f.ID = ID;
                    r2.Close();

                    DAL.Connection.Close();
                    f.koeficijenti = DAL.Factory.getKoeficijentDAO().getByIgraID(ID);

                    DAL.Connection.Open();
                    return f;
                }
                else
                {
                    r2.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DAL.Connection.Close();
            }
        }

        

        public List<FudbalskaUtakmica> getAll()
        {
            //vjerojatno ne radi
            try
            {
                DAL.Connection.Open(); 
             
                MySqlCommand c1 = new MySqlCommand("select * from FudbalskeUtakmice", DAL.Connection);
                List<FudbalskaUtakmica> lista = new List<FudbalskaUtakmica>();
                MySqlDataReader r, r2 = c1.ExecuteReader();
                while(r2.Read())
                {
                    int ID = r2.GetInt32("ID");
                    c = new MySqlCommand("select * from Igre where id=" + ID, DAL.Connection);
                    r = c.ExecuteReader();

                    r.Read();
       
                    FudbalskaUtakmica f = new FudbalskaUtakmica(r.GetDateTime("Pocetak"), r.GetString("Naziv"), 
                            encodeStatus(r.GetInt32("StatusIgre")), r2.GetString("Domacin"), 
                            r2.GetString("Gost"), r2.GetInt32("PoeniDomacin"), r2.GetInt32("PoeniGost"));

                    f.ID = ID;

                    lista.Add(f);

                    
                }
                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DAL.Connection.Close();
            }
        }

        public List<FudbalskaUtakmica> getByExample(string name, string value)
        {
            throw new NotImplementedException();
        }
    }
}

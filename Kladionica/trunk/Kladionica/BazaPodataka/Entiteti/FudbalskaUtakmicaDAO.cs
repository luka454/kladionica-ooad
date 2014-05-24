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
                //moguće greške sa smještanjem DATETIME u bazu
                //rijašiti tako da DateTIme konverutjemo u string, a iz stringa u bazi u DateTime
                //Ponude ID nije riješeno kako treba
                c = new MySqlCommand("insert into Igre(Pocetak, StatusIgre, Naziv, IgreType_ID, Ponude_ID)" +
                    " values( " + entity.Pocetak + ", " + codeStatus(entity.statusIgre) + ", " + entity.Naziv + ", " +
                    1 + ", " + 0 + ")", DAL.Connection);
                c.ExecuteNonQuery();

                long ID = c.LastInsertedId;

                c = new MySqlCommand("insert into FudbalskeUtakmice(ID, Domacin, Gost, PoeniDomacin, PoeniGost)" +
                    " values( " + ID + ", " + entity.Domacin + ", " + entity.Gost + ", " +
                    entity.PoeniDomacin + ", " + entity.PoeniGost + ")", DAL.Connection);
                c.ExecuteNonQuery();

                return ID;
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

        private int codeStatus(StatusIgre statusIgre)
        {
            throw new NotImplementedException();
        }

        public FudbalskaUtakmica read(FudbalskaUtakmica entity)
        {
            return getById(entity.ID);
        }

        public FudbalskaUtakmica update(FudbalskaUtakmica entity)
        {
            try
            {
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
                c = new MySqlCommand("select * from Igre where id=" + id, DAL.Connection);
                MySqlCommand c1  = new MySqlCommand("select * from FudbalskeUtakmice where id=" + id, DAL.Connection);
                MySqlDataReader r = c.ExecuteReader(), r2 = c1.ExecuteReader();
                if (r.Read() && r2.Read())
                {
                    int ID = r.GetInt32("ID");
                    FudbalskaUtakmica f = new FudbalskaUtakmica(r.GetDateTime("Pocetak"), r.GetString("Naziv"), encodeStatus(r.GetInt32("StatusIgre")), r2.GetString("Domacin"), r2.GetString("Gost"), r2.GetInt32("PoeniDomacin"), r2.GetInt32("PoeniGost"));

                    f.ID = ID;

                    return f;
                }
                else
                    return null;
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

        private StatusIgre encodeStatus(int p)
        {
            throw new NotImplementedException();
        }

        public List<FudbalskaUtakmica> getAll()
        {
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

using Kladionica.BazaPodataka.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kladionica.BazaPodataka
{
    public class TenisDAO : IDaoCrud<Tenis> 
    {
        protected MySqlCommand c;
        public long create(Tenis entity)
        {
            try
            {
                DAL.Connection.Open(); 

                //moguće greške sa smještanjem DATETIME u bazu
                //rijašiti tako da DateTIme konverutjemo u string, a iz stringa u bazi u DateTime
                //Ponude ID nije riješeno kako treba
                c = new MySqlCommand("insert into Igre(Pocetak, StatusIgre, Naziv, IgreType_ID, Ponude_ID)" +
                    " values( " + entity.Pocetak + ", " + codeStatus(entity.statusIgre) + ", " + entity.Naziv + ", " +
                    2 + ", " + 0 + ")", DAL.Connection);
                c.ExecuteNonQuery();

                long ID = c.LastInsertedId;

                c = new MySqlCommand("insert into FudbalskeUtakmice(ID, PrviProtivnik, DrugiProtivnik, PrviPoenaSetova, DrugiPoenaSetova)" +
                    " values( " + ID + ", " + entity.PrviProtivnik + ", " + entity.DrugiProtivnik + ", " +
                    entity.PrviPoenaSetova + ", " + entity.DrugiPoenaSetova + ")", DAL.Connection);
                c.ExecuteNonQuery();

                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private int codeStatus(StatusIgre statusIgre)
        {
            throw new NotImplementedException();
        }

        public Tenis read(Tenis entity)
        {
            return getById(entity.ID);
        }

        public Tenis update(Tenis entity)
        {
            try
            {
                DAL.Connection.Open(); 

                c = new MySqlCommand(String.Format("update Igre set Pocetak={0}, StatusIgre={1}, Naziv={2}, IgreType_ID={3}, Ponude_ID={4} where id={5}",
                entity.Pocetak, codeStatus(entity.statusIgre), entity.Naziv, 2, 0, entity.ID), DAL.Connection);
                c.ExecuteNonQuery();

               
                c = new MySqlCommand(String.Format("insert into FudbalskeUtakmice set PrviProtivnik={0}, DrugiProtivnik={1}, PrviPoeniSetova={2}, DrugiPoenaSetova={3} where id={4})",
                    entity.PrviProtivnik, entity.DrugiProtivnik, entity.PrviPoenaSetova, entity.DrugiPoenaSetova, entity.ID), DAL.Connection);
                c.ExecuteNonQuery();


                return getById(entity.ID);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(Tenis entity)
        {
            try
            {
                DAL.Connection.Open(); 

                int id = Convert.ToInt32(entity.ID);
                c = new MySqlCommand("delete from Igre where id=" + id, DAL.Connection);
                c.ExecuteNonQuery();

                c = new MySqlCommand("delete from Tenis where id=" + id, DAL.Connection);
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

        public Tenis getById(int id)
        {
            try
            {
                c = new MySqlCommand("select * from Igre where id=" + id, DAL.Connection);
                MySqlCommand c1 = new MySqlCommand("select * from FudbalskeUtakmice where id=" + id, DAL.Connection);
                MySqlDataReader r = c.ExecuteReader(), r2 = c1.ExecuteReader();
                if (r.Read() && r2.Read())
                {
                    int ID = r.GetInt32("ID");
                    Tenis f = new Tenis(r.GetDateTime("Pocetak"), r.GetString("Naziv"),
                            encodeStatus(r.GetInt32("StatusIgre")), r2.GetString("PrviProtivnik"),
                            r2.GetString("DrugiProtivnik"), r2.GetInt32("PrviPoenaSetova"), r2.GetInt32("DrugiPoenaSetova"));

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
        }

        private StatusIgre encodeStatus(int p)
        {
            throw new NotImplementedException();
        }

        public List<Tenis> getAll()
        {
            try
            {
                DAL.Connection.Open(); 

                MySqlCommand c1 = new MySqlCommand("select * from Tenis", DAL.Connection);
                List<Tenis> lista = new List<Tenis>();
                MySqlDataReader r, r2 = c1.ExecuteReader();
                while (r2.Read())
                {
                    int ID = r2.GetInt32("ID");
                    c = new MySqlCommand("select * from Igre where id=" + ID, DAL.Connection);
                    r = c.ExecuteReader();

                    r.Read();

                    Tenis f = new Tenis(r.GetDateTime("Pocetak"), r.GetString("Naziv"),
                            encodeStatus(r.GetInt32("StatusIgre")), r2.GetString("PrviProtivnik"),
                            r2.GetString("DrugiProtivnik"), r2.GetInt32("PrviPoenaSetova"), r2.GetInt32("DrugiPoenaSetova"));

                    f.ID = ID;

                    lista.Add(f);


                }
                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Tenis> getByExample(string name, string value)
        {
            throw new NotImplementedException();
        }

    }
}

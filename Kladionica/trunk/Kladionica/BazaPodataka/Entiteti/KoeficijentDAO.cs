using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Kladionica.BazaPodataka.Interfejsi;
using System.Globalization;

namespace Kladionica.BazaPodataka
{
    public class KoeficijentDAO: IDaoCrud<Koeficijent>
    {
        protected MySqlCommand c;
        public long create(Koeficijent entity)
        {
            throw new Exception("Nije moguce koristiti bez ID-a igre");
            /*   try
            {
                DAL.Connection.Open();
                c = new MySqlCommand("insert into Koeficijenti(tip, koeficijent)" +
                    " values( " + entity.tip + ", " + entity.koeficijent + ")", DAL.Connection);
                c.ExecuteNonQuery();

                
                return c.LastInsertedId;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                DAL.Connection.Close();
            }*/
        }

        public long create(Koeficijent entity, long igraID = 0)
        {
            try
            {
                DAL.Connection.Open();

                
                string com = String.Format("INSERT INTO `kladionica`.`koeficijenti` (`ID`, `Tip`, `koeficijent`, `IgraID`) VALUES (NULL, '{0}', '{1}', '{2}')",
                            entity.tip, entity.koeficijent.ToString(CultureInfo.InvariantCulture), igraID);
                c = new MySqlCommand(com, DAL.Connection);
                c.ExecuteNonQuery();

                return c.LastInsertedId;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                DAL.Connection.Close();
            }
        }

        public Koeficijent read(Koeficijent entity)
        {
            return getById(entity.ID);
        }

        public Koeficijent update(Koeficijent entity)
        {
            try
            {
                DAL.Connection.Open();
                c = new MySqlCommand("update Koeficijenti set tip=" + entity.tip +
                    ", koeficijent=" + entity.koeficijent + "where id=" + entity.ID, DAL.Connection);
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

        public void delete(Koeficijent entity)
        {
            try
            {
                DAL.Connection.Open();
                int id = Convert.ToInt32(entity.ID);
                c = new MySqlCommand("delete from Koeficijenti where id=" + id, DAL.Connection);
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

        public Koeficijent getById(int id)
        {
            try
            {
                DAL.Connection.Open();
                c = new MySqlCommand("select * from Koeficijenti where id=" + id, DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                if (r.Read())
                {
                    
                    Koeficijent k = new Koeficijent(r.GetString("tip"), r.GetDecimal("koeficijent"));
                    r.Close();
                    return k;
                }
                else
                {
                    r.Close();
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

        public List<Koeficijent> getAll()
        {
            try
            {
                DAL.Connection.Open();
                c = new MySqlCommand("select * from Koeficijenti", DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                List<Koeficijent> koeficijenti = new List<Koeficijent>();
                while (r.Read())
                    koeficijenti.Add(new Koeficijent(r.GetString("tip"), r.GetDecimal("koeficijent")));

                r.Close();
                return koeficijenti;
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

        public List<Koeficijent> getByIgraID(int IgraID)
        {
            try
            {
                DAL.Connection.Open();
                c = new MySqlCommand("select * from Koeficijenti where IgraID=" + IgraID, DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                List<Koeficijent> koeficijenti = new List<Koeficijent>();
                while (r.Read())
                {
                    
                    koeficijenti.Add(new Koeficijent(r.GetString("tip"), r.GetDecimal("koeficijent")));
                   
                }
                r.Close();
                return koeficijenti;
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
    }
}

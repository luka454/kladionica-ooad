using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Kladionica.BazaPodataka.Interfejsi;

namespace Kladionica.BazaPodataka
{
    public class PonudaDAO: IDaoCrud<Ponuda>
    {
        protected MySqlCommand c;
        private static string dateFormat = "yyyy-MM-dd";
        public long create(Ponuda entity)
        {
            try
            {
                DAL.Connection.Open();
                c = new MySqlCommand("insert into Ponude(datum)" +
                    " values( '" + entity.Datum.ToString(dateFormat) + "')", DAL.Connection);
                c.ExecuteNonQuery();
                return c.LastInsertedId;
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

        public Ponuda read(Ponuda entity)
        {
            return getById(entity.ID);
        }

        public Ponuda update(Ponuda entity)
        {
            try
            {
                DAL.Connection.Open();
                c = new MySqlCommand("update Ponude set datum=" + entity.Datum + "where id=" + entity.ID, DAL.Connection);
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

        public void delete(Ponuda entity)
        {
            try
            {
                DAL.Connection.Open();

                int id = Convert.ToInt32(entity.ID);
                c = new MySqlCommand("delete from Ponude where id=" + id, DAL.Connection);
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

        public Ponuda getById(int id)
        {
            try
            {
                DAL.Connection.Open();

                c = new MySqlCommand("select * from Ponude where id=" + id, DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                if (r.Read())
                {
                    Ponuda p = new Ponuda(r.GetDateTime("datum"));
                    DAL.Connection.Close();
                    r.Close();

                    p.IgreUPonudi = DAL.Factory.getIgraDao().getByPonuda(p);
                    return p;
                }
                else
                {
                    DAL.Connection.Close();
                    r.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Ponuda> getAll()
        {
            try
            {
                DAL.Connection.Open();
                c = new MySqlCommand("select * from Ponude", DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                List<Ponuda> ponude = new List<Ponuda>();

                while (r.Read())
                {
                    Ponuda p = new Ponuda(r.GetDateTime("datum"));
                    p.ID = r.GetInt32("id");
                    ponude.Add(p);
                }
                r.Close();

                DAL.Connection.Close();

                foreach (var item in ponude)
                {
                    item.IgreUPonudi = DAL.Factory.getIgraDao().getByPonuda(item);
                }

                return ponude;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public List<Ponuda> getAllWithoutGames()
        {
            try
            {
                DAL.Connection.Open();
                List<Ponuda> ponude = new List<Ponuda>();
                c = new MySqlCommand("select * from Ponude", DAL.Connection);

                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                {
                    Ponuda ponuda = new Ponuda(r.GetDateTime("datum"));
                    ponuda.ID = r.GetInt32("id");

                   
                    ponude.Add(ponuda);
                    
                }
                DAL.Connection.Close();
                r.Close();

                return ponude;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Ponuda getByExample(DateTime datum)
        {
            try
            {
                DAL.Connection.Open();

                c = new MySqlCommand("select * from Ponude where datum= '" + datum.ToString(dateFormat) + "'", DAL.Connection);
                
                MySqlDataReader r = c.ExecuteReader();
                if (!r.Read())
                {
                    r.Close();
                    DAL.Connection.Close();
                    return null;
                }

                Ponuda ponuda = new Ponuda(r.GetDateTime("datum"));
                ponuda.ID = r.GetInt32("id");
                DAL.Connection.Close();
                r.Close();

                
                ponuda.IgreUPonudi = DAL.Factory.getIgraDao().getByPonuda(ponuda);
                return ponuda;

               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

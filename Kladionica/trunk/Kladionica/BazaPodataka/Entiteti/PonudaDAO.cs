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
        public long create(Ponuda entity)
        {
            try
            {
                c = new MySqlCommand("insert into Ponude(datum)" +
                    " values( " + entity.Datum + ")", DAL.Connection);
                c.ExecuteNonQuery();
                return c.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw ex;
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
                c = new MySqlCommand("update Ponude set datum=" + entity.Datum + "where id=" + entity.ID, DAL.Connection);
                c.ExecuteNonQuery();
                return getById(entity.ID);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(Ponuda entity)
        {
            try
            {
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
                c = new MySqlCommand("select * from Ponude where id=" + id, DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                if (r.Read())
                {
                    Ponuda p = new Ponuda(r.GetDateTime("datum"));
                    return p;
                }
                else
                    return null;
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
                c = new MySqlCommand("select * from Ponude", DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                List<Ponuda> ponude = new List<Ponuda>();
                while (r.Read())
                    ponude.Add(new Ponuda(r.GetDateTime("datum")));
                return ponude;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Ponuda> getByExample(DateTime date)
        {
            try
            {
                c = new MySqlCommand("select * from Ponude where datum=" + date, DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                List<Ponuda> ponude = new List<Ponuda>();
                while (r.Read())
                    ponude.Add(new Ponuda(r.GetDateTime("datum")));
                return ponude;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

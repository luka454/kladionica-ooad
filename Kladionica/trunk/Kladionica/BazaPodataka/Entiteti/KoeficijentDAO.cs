using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Kladionica.BazaPodataka.Interfejsi;

namespace Kladionica.BazaPodataka
{
    public class KoeficijentDAO: IDaoCrud<Koeficijent>
    {
        protected MySqlCommand c;
        public long create(Koeficijent entity)
        {
            try
            {
                c = new MySqlCommand("insert into koeficijenti(tip, koeficijent)" +
                    " values( " + entity.tip + ", " + entity.koeficijent + ")", DAL.Connection);
                c.ExecuteNonQuery();
                return c.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw ex;
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
                c = new MySqlCommand("update koeficijenti set tip=" + entity.tip +
                    ", koeficijent=" + entity.koeficijent + "where id=" + entity.ID, DAL.Connection);
                c.ExecuteNonQuery();
                return getById(entity.ID);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(Koeficijent entity)
        {
            try
            {
                int id = Convert.ToInt32(entity.ID);
                c = new MySqlCommand("delete from koeficijenti where id=" + id, DAL.Connection);
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
                c = new MySqlCommand("select * from koeficijenti where id=" + id, DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                if (r.Read())
                {
                    Koeficijent k=new Koeficijent(r.GetString("tip"), r.GetFloat("koeficijent"));
                    return k;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Koeficijent> getAll()
        {
            try
            {
                c = new MySqlCommand("select * from koeficijenti", DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                List<Koeficijent> koeficijenti = new List<Koeficijent>();
                while (r.Read())
                    koeficijenti.Add(new Koeficijent(r.GetString("tip"), r.GetFloat("koeficijent")));
                return koeficijenti;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Koeficijent> getByExample(string name, float value)
        {
            try
            {
                c = new MySqlCommand("select * from koeficijenti where tip=" + name + " and koeficijent=" + value, DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                List<Koeficijent> koeficijenti = new List<Koeficijent>();
                while (r.Read())
                    koeficijenti.Add(new Koeficijent(r.GetString("tip"), r.GetFloat("koeficijent")));
                return koeficijenti;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

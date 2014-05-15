using Kladionica.BazaPodataka.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica.BazaPodataka
{
    class TenisDAO : IDaoCrud<Tenis> 
    {
        protected MySqlCommand c;
        public long create(Tenis entity)
        {
            try
            {
                c = new MySqlCommand("insert into teniski_mecevi(prvi, drugi, set1, set2)" +
                    " values( " + entity.PrviProtivnik + ", " + entity.DrugiProtivnik + ", " + entity.PrviPoenaSetova + ", " , entity.DrugiPoenaSetova")", DAL.Connection);
                c.ExecuteNonQuery();
                return c.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Tenis read(Tenis entity)
        {
            return getById(entity.ID);
        }

        public Tenis update(Tenis entity)
        {
            try
            {
                c = new MySqlCommand("update radnice set prvi=" + entity.PrviProtivnik +
                    ", drugi=" + entity.DrugiProtivnik + ", set1=" + entity.PrviPoenaSetova + ", set2=" + entity.DrugiPoenaSetova, DAL.Connection);
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
                int id = Convert.ToInt32(entity.ID);
                c = new MySqlCommand("delete from teniski_mecevi where id=" + id, DAL.Connection);
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
                c = new MySqlCommand("select * from teniski_mecevi where id=" + id, DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                if (r.Read())
                {
                    Tenis mec = new Tenis(r.GetString("prvi"), r.GetString("drugi"), r.GetInt32("set1"), r.GetInt32("set2"));
                    return mec;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Radnica> getAll()
        {
            try
            {
                c = new MySqlCommand("select * from teniski_mecevi", DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                List<Tenis> mecevi = new List<Tenis>();
                while (r.Read())
                    mecevi.Add(new Tenis(r.GetString("prvi"), r.GetString("drugi"), r.GetInt32("set1"), r.GetInt32("set2")));
                return mecevi;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

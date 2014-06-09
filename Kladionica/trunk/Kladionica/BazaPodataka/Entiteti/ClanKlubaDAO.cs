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
    public class ClanKlubaDAO : IDaoCrud<ClanKluba>
    {
        protected MySqlCommand c;
        public long create(ClanKluba entity)
        {
            try
            {
                DAL.Connection.Open();
                c = new MySqlCommand("insert into ClanKluba(Ime, Prezime, Username, HashPassworda, PIN, Novac)" +
                " values( '" + entity.Ime + "', '" + entity.Prezime + "', '" + entity.Username + "', " +
                entity.HashPassword + ", " + entity.PIN + ", " + entity.Novac.ToString(CultureInfo.InvariantCulture) + ")", DAL.Connection);
                c.ExecuteNonQuery();
                DAL.Connection.Close();
                return c.LastInsertedId;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                throw ex;
            }

        }

        public ClanKluba read(ClanKluba entity)
        {
            return getById(entity.ID);
        }

        public ClanKluba update(ClanKluba entity)
        {
            try
            {
                c = new MySqlCommand("update ClanKluba set ime=" + entity.Ime +
                    ", prezime=" + entity.Prezime + ", username=" + entity.Username + ", hashpassword=" +
                    entity.HashPassword + "where id=" + entity.ID, DAL.Connection);
                c.ExecuteNonQuery();
                return getById(entity.ID);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(ClanKluba entity)
        {
            try
            {
                int id = Convert.ToInt32(entity.ID);
                c = new MySqlCommand("delete from ClanKluba where id=" + id, DAL.Connection);
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

        public ClanKluba getById(int id)
        {
            try
            {
                c = new MySqlCommand("select * from ClanKluba where id=" + id, DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                if (r.Read())
                {
                    ClanKluba ck = new ClanKluba(r.GetString("ime"), r.GetString("prezime"), r.GetString("username"),
                        r.GetInt32("hashpassword"));
                    return ck;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ClanKluba> getAll()
        {
            try
            {
                c = new MySqlCommand("select * from ClanKluba", DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                List<ClanKluba> clanovi = new List<ClanKluba>();
                while (r.Read())
                    clanovi.Add(new ClanKluba(r.GetString("ime"), r.GetString("prezime"), r.GetString("username"),
                        r.GetInt32("hashpassword")));
                return clanovi;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ClanKluba> getByExample(string name, string value)
        {
            try
            {
                c = new MySqlCommand("select * from ClanKluba where ime=" + name + " and prezime=" + value, DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                List<ClanKluba> clanovi = new List<ClanKluba>();
                while (r.Read())
                    clanovi.Add(new ClanKluba(r.GetString("ime"), r.GetString("prezime"), r.GetString("username"),
                        r.GetInt32("hashpassword")));
                return clanovi;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

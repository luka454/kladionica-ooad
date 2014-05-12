using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Kladionica.BazaPodataka.Interfejsi;

namespace Kladionica.BazaPodataka
{
    public partial class DAL
    {
        public class ClanKlubaDAO : IDaoCrud<ClanKluba>
        {
            protected MySqlCommand c;
            public long create(ClanKluba entity)
            {
                try
                {
                    c = new MySqlCommand("insert into clanovi(ime, prezime, username, hashpassword)" +
                        " values( " + entity.Ime + ", " + entity.Prezime + ", " + entity.Username + ", " +
                        entity.HashPassword + ")", _con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception ex)
                {
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
                    c = new MySqlCommand("update clanovi set ime=" + entity.Ime +
                        ", prezime=" + entity.Prezime + ", username=" + entity.Username + ", hashpassword=" +
                        entity.HashPassword + "where id=" + entity.ID, _con);
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
                    c = new MySqlCommand("delete from clanovi where id=" + id, _con);
                    c.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    _con.Close();
                }
            }

            public ClanKluba getById(int id)
            {
                try
                {
                    c = new MySqlCommand("select * from clanovi where id=" + id, _con);
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
                    c = new MySqlCommand("select * from clanovi", _con);
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
                    c = new MySqlCommand("select * from clanovi where ime=" + name + " and prezime=" + value, _con);
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
}

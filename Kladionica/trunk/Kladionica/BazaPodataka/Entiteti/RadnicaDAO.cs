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
        public class RadnicaDAO : IDaoCrud<Radnica>
        {
            protected MySqlCommand c;
            public long create(Radnica entity)
            {
                try
                {
                    c = new MySqlCommand("insert into radnice(ime, prezime, username, hashpassword, plata)" +
                        " values( " + entity.Ime + ", " + entity.Prezime + ", " + entity.Username + ", " +
                        entity.HashPassword + ", " + entity.Plata + ")", Con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

            public Radnica read(Radnica entity)
            {
                return getById(entity.ID);
            }

            public Radnica update(Radnica entity)
            {
                try
                {
                    c = new MySqlCommand("update radnice set ime=" + entity.Ime +
                        ", prezime=" + entity.Prezime + ", username=" + entity.Username + ", hashpassword=" +
                        entity.HashPassword + ", plata=" + entity.Plata + "where id=" + entity.ID, Con);
                    c.ExecuteNonQuery();
                    return getById(entity.ID);
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void delete(Radnica entity)
            {
                try
                {
                    int id = Convert.ToInt32(entity.ID);
                    c = new MySqlCommand("delete from radnice where id=" + id, Con);
                    c.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Con.Close();
                }
            }

            public Radnica getById(int id)
            {
                try
                {
                    c = new MySqlCommand("select * from radnice where id=" + id, Con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Radnica rad = new Radnica(r.GetString("ime"), r.GetString("prezime"), r.GetString("username"),
                            r.GetInt32("hashpassword"), r.GetDecimal("plata"));
                        return rad;
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
                    c = new MySqlCommand("select * from radnice", Con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Radnica> radnice = new List<Radnica>();
                    while (r.Read())
                        radnice.Add(new Radnica(r.GetString("ime"), r.GetString("prezime"), r.GetString("username"),
                            r.GetInt32("hashpassword"), r.GetDecimal("plata")));
                    return radnice;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<Radnica> getByExample(string name, string value)
            { 
                try 
                { 
                    c = new MySqlCommand("select * from radnice where ime=" + name + " and prezime=" + value, Con);
                    MySqlDataReader r = c.ExecuteReader(); 
                    List<Radnica> radnice = new List<Radnica>();
                    while (r.Read())
                        radnice.Add(new Radnica(r.GetString("ime"), r.GetString("prezime"), r.GetString("username"),
                            r.GetInt32("hashpassword"), r.GetDecimal("plata")));
                    return radnice; 
                } 
                catch (Exception ex) 
                { 
                    throw ex; 
                } 
            }
        }
    }
}

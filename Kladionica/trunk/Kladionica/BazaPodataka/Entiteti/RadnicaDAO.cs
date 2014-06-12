using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Kladionica.BazaPodataka.Interfejsi;

namespace Kladionica.BazaPodataka
{
    public class RadnicaDAO : IDaoCrud<Radnica>
    {
        protected MySqlCommand c;
        public long create(Radnica entity)
        {
            try
            {
                DAL.Connection.Open();
                c = new MySqlCommand("insert into Radnik(ime, prezime, username, hashpassworda, Plata)" +
                    " values(' " + entity.Ime + "', '" + entity.Prezime + "', '" + entity.Username + "', " +
                    entity.HashPassword + ", " + Convert.ToDouble(entity.Plata) + ")", DAL.Connection);
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

        public Radnica read(Radnica entity)
        {
            return getById(entity.ID);
        }

        public Radnica update(Radnica entity)
        {
            try
            {
                DAL.Connection.Open();
                c = new MySqlCommand("update Radnik set ime=" + entity.Ime +
                    ", prezime=" + entity.Prezime + ", username=" + entity.Username + ", hashpassword=" +
                    entity.HashPassword + ", plata=" + entity.Plata + "where id=" + entity.ID, DAL.Connection);
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

        public void delete(Radnica entity)
        {
            try
            {
                DAL.Connection.Open();
                int id = Convert.ToInt32(entity.ID);
                c = new MySqlCommand("delete from Radnik where id=" + id, DAL.Connection);
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

        public Radnica getById(int id)
        {
            try
            {
                DAL.Connection.Open();
                c = new MySqlCommand("select * from Radnik where id=" + id, DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                if (r.Read())
                {
                    Radnica rad = new Radnica(r.GetString("ime"), r.GetString("prezime"), r.GetString("username"),
                        r.GetInt32("hashpassworda"), r.GetDecimal("plata"));
                    return rad;
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

        public List<Radnica> getAll()
        {
            try
            {
                DAL.Connection.Open();
                c = new MySqlCommand("select * from Radnik", DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                List<Radnica> radnice = new List<Radnica>();
                while (r.Read())
                    radnice.Add(new Radnica(r.GetString("ime"), r.GetString("prezime"), r.GetString("username"),
                        r.GetInt32("hashpassworda"), r.GetDecimal("plata")));
                return radnice;
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

        public List<Radnica> getByPlata(decimal plata)
        { 
            try 
            {
                DAL.Connection.Open();
                c = new MySqlCommand("select * from Radnik where plata=" + plata, DAL.Connection);
                MySqlDataReader r = c.ExecuteReader(); 
                List<Radnica> radnice = new List<Radnica>();
                while (r.Read())
                    radnice.Add(new Radnica(r.GetString("ime"), r.GetString("prezime"), r.GetString("username"),
                        r.GetInt32("hashpassworda"), r.GetDecimal("plata")));
                return radnice; 
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

        public Radnica getByUsername(string username)
        {
            try
            {
                DAL.Connection.Open();
                c = new MySqlCommand("select * from Radnik where username= '" + username + "'", DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                if (r.Read())
                {
                    Radnica rad = new Radnica(r.GetString("ime"), r.GetString("prezime"), r.GetString("username"),
                        r.GetInt32("hashpassworda"), r.GetDecimal("plata"));

                    rad.ID = r.GetInt32("id");
                    return rad;
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
    }
}

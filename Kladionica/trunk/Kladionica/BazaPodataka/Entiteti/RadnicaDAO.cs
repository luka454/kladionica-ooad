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
                c = new MySqlCommand("insert into Radnik(ime, prezime, username, hashpassword, plata)" +
                    " values( " + entity.Ime + ", " + entity.Prezime + ", " + entity.Username + ", " +
                    entity.HashPassword + ", " + entity.Plata + ")", DAL.Connection);
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
        }

        public void delete(Radnica entity)
        {
            try
            {
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
                c = new MySqlCommand("select * from Radnik where id=" + id, DAL.Connection);
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
                c = new MySqlCommand("select * from Radnik", DAL.Connection);
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
                c = new MySqlCommand("select * from Radnik where ime=" + name + " and prezime=" + value, DAL.Connection);
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

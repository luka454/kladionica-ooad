using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kladionica.BazaPodataka
{
    class TransakcijaDAO
    {
         protected MySqlCommand c;
        public long create(Transakcija entity)
        {
            try
            {
                c = new MySqlCommand("insert into transakcije(id, datum, iznos, korisnik_id)" +
                    " values( " + entity.ID + ", " + entity.Vrijeme + ", " + entity.Iznos +
                    ", " + entity.KojiKorisnik.ID + ")", DAL.Connection);
                c.ExecuteNonQuery();
                return c.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Transakcija read(Transakcija entity)
        {
            return getById(entity.ID);
        }

        public Transakcija update(Transakcija entity)
        {
            try
            {
                c = new MySqlCommand("update transakcije set id=" + entity.ID +
                    ", datum=" + entity.Vrijeme + ", iznos=" + entity.Iznos + ", korisnik_id=" +
                    entity.KojiKorisnik.ID, DAL.Connection);
                c.ExecuteNonQuery();
                return getById(entity.ID);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(Transakcija entity)
        {
            try
            {
                int id = Convert.ToInt32(entity.ID);
                c = new MySqlCommand("delete from transakcije where id=" + id, DAL.Connection);
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

        public Transakcija getById(int id)
        {
            try
            {
                c = new MySqlCommand("select * from transakcije where id=" + id, DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                if (r.Read())
                {
                    Transakcija transakcija = new Transakcija(r.GetDateTime("datum"), r.GetDecimal("username"),new ClanKluba());
                    return transakcija;
                    //implementiraj clan kluba do kraja obavezo!!!
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Transakcija> getAll()
        {
            try
            {
                c = new MySqlCommand("select * from transakcije", DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();
                List<Transakcija> transakcije = new List<Transakcija>();
                while (r.Read())
                    transakcije.Add( new Transakcija(r.GetDateTime("datum"), r.GetDecimal("username"),new ClanKluba()));
                    return transakcije;
                    //implementiraj clan kluba do kraja obavezo!!!
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Transakcija> getByExample(string name, string value)
        { 
            try 
            { 
            } 
            catch (Exception ex) 
            { 
                throw ex; 
            } 
        }
    }
    
}

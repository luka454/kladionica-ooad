using Kladionica.BazaPodataka.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kladionica.BazaPodataka
{
    public class IgraDAO //: Interfejsi.IDaoCrud<Igra>
    {
        protected MySqlCommand c;
        public long create(Igra entity, Ponuda p)
        {
            if ((entity as FudbalskaUtakmica) != null)
                return DAL.Factory.getFudbalskaUtakmicaDao().create(entity as FudbalskaUtakmica, p);
            

            else if ((entity as Tenis) != null)
                return DAL.Factory.getTenisDao().create(entity as Tenis, p);

            return -1;
        }

        public Igra read(Igra entity)
        {
            if ((entity as FudbalskaUtakmica) != null)
                return DAL.Factory.getFudbalskaUtakmicaDao().read(entity as FudbalskaUtakmica);

            else if ((entity as Tenis) != null)
                return DAL.Factory.getTenisDao().read(entity as Tenis);

            return null;

        }

        public Igra update(Igra entity)
        {
            if ((entity as FudbalskaUtakmica) != null)
                return DAL.Factory.getFudbalskaUtakmicaDao().update(entity as FudbalskaUtakmica);

            else if ((entity as Tenis) != null)
                return DAL.Factory.getTenisDao().update(entity as Tenis);

            return null;

        }

        public void delete(Igra entity)
        {
            if ((entity as FudbalskaUtakmica) != null)
                DAL.Factory.getFudbalskaUtakmicaDao().delete(entity as FudbalskaUtakmica);

            else if ((entity as Tenis) != null)
                DAL.Factory.getTenisDao().delete(entity as Tenis);

        }

        public Igra getById(int id)
        {
            FudbalskaUtakmica f = DAL.Factory.getFudbalskaUtakmicaDao().getById(id);
            if (f != null) return f;

            else 
                return DAL.Factory.getTenisDao().getById(id);

        }

        public List<Igra> getAll()
        {
            List<Igra> igre = new List<Igra>();

            try
            {
                DAL.Connection.Open();

                MySqlCommand c1 = new MySqlCommand("select * from Igre", DAL.Connection);
                List<Igra> lista = new List<Igra>();
                MySqlDataReader r = c1.ExecuteReader();
                while (r.Read())
                {
                    int ID = r.GetInt32("ID");
                    switch (r.GetInt32("igretype"))
                    {
                        case 1: //Fudbalska utakmica

                            FudbalskaUtakmica f = DAL.Factory.getFudbalskaUtakmicaDao().getById(ID);
                            lista.Add(f);
                            break;
                        case 2: //teniska utakmica
                            Tenis t = DAL.Factory.getTenisDao().getById(ID);
                            lista.Add(t);
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DAL.Connection.Close();
            }
            return igre;
        }

        public List<Igra> getByPonuda(Ponuda p)
        {
            return getByPonuda(p.ID);
        }

        private List<Igra> getByPonuda(int p)
        {
            List<Igra> lista = new List<Igra>();
                
            try
            {
                
                    DAL.Connection.Open();
                
                MySqlCommand c1 = new MySqlCommand("select * from Igre where ponude_id = " + p.ToString(), DAL.Connection);

                List<int> Idovi = new List<int>(), type_idovi = new List<int>();
                
                MySqlDataReader r = c1.ExecuteReader();
                while (r.Read())
                {
                    Idovi.Add(r.GetInt32("ID"));
                    type_idovi.Add(r.GetInt32("igretype_id"));
                }
                r.Close();
                DAL.Connection.Close();

                for (int i = 0; i < Idovi.Count; i++)
                {
                    switch (type_idovi[i])
                    {
                        case 1: //Fudbalska utakmica
                           
                            FudbalskaUtakmica f = DAL.Factory.getFudbalskaUtakmicaDao().getById(Idovi[i]);
                            lista.Add(f);
                            break;
                        case 2: //teniska utakmica
                           
                            Tenis t = DAL.Factory.getTenisDao().getById(Idovi[i]);
                            lista.Add(t);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DAL.Connection.Close();
            }
            return lista;
        }
    }
}

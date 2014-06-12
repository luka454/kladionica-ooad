using Kladionica.BazaPodataka.Interfejsi;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kladionica;
using System.Globalization;

namespace Kladionica.BazaPodataka
{
    public class TiketDAO: IDaoCrud<Tiket>
    {
        protected MySqlCommand c;
        public long create(Tiket entity)
        {
            try
            {
                DAL.Connection.Open();
                string str = (entity.Vlasnik != null ? entity.Vlasnik.ToString() : "0");
                string cmd = String.Format("insert into tiketi(tiptiketa, ulog, clankluba_id) values ('{0}', '{1}', '{2}')",
                    1, entity.Ulog, str);
                c = new MySqlCommand(cmd, DAL.Connection);
                c.ExecuteNonQuery();

                long ID = c.LastInsertedId;

                foreach (var item in entity.DajIgre())
	            {
                    
		            cmd = String.Format("insert into stavketiketa(tiketi_id, igre_id, odigranitip) values('{0}', '{1}', '{2}')",
                         ID, item.OdigranaIgra.ID, item.OdigraniTip);
                    c = new MySqlCommand(cmd, DAL.Connection);
                    c.ExecuteNonQuery();

	            }
                
                DAL.Connection.Close();

                return ID;
            }
            catch (Exception ex)
            {
                
                throw;
            }
           
        }

        public Tiket read(Tiket entity)
        {
            throw new NotImplementedException();
        }

        public Tiket update(Tiket entity)
        {
            throw new NotImplementedException();
        }

        public void delete(Tiket entity)
        {
            try
            {
                DAL.Connection.Open();
                string cmd = "delete from stavketiketa where tiketi_id = " + entity.ID;
                c = new MySqlCommand(cmd, DAL.Connection);
                c.ExecuteNonQuery();

                cmd = "delete from tiketi where id = " + entity.ID;
                c = new MySqlCommand(cmd, DAL.Connection);
                c.ExecuteNonQuery();

                DAL.Connection.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Tiket getById(int id)
        {
            try
            {
                DAL.Connection.Open();
                string cmd = "select * from tiketi where id = " + id;
                c = new MySqlCommand(cmd, DAL.Connection);
                MySqlDataReader r = c.ExecuteReader();

                if (!r.Read()) return null;

                Tiket t = new Tiket(0,r.GetDecimal("ulog"),TipTiketa.Normalni);
                t.ID = r.GetInt32("ID");
                t.OdigraneIgre = new List<StavkaTiketa>();
                r.Close();

                cmd = "select * from stavke tiketa where tiketi_id = " + id;
                c = new MySqlCommand(cmd, DAL.Connection);
                r = c.ExecuteReader();

               

                List<Tuple<int, string>> podaci = new List<Tuple<int, string>>();
                while (r.Read())
                {
                    podaci.Add(new Tuple<int, string>(r.GetInt32("igre_id"), r.GetString("OdigraniTip")));
                }

                r.Close();

                DAL.Connection.Close();

                foreach (var item in podaci)
                {
                    Igra i = DAL.Factory.getIgraDao().getById(item.Item1);
                    t.OdigraneIgre.Add(new StavkaTiketa(item.Item2, i));
                }

                t.ProracujaUkupniKoeficijent();

                return t;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                throw;
            }
        }

        public void updateUlog(Tiket entitet, Decimal ulog)
        {
            try
            {
                DAL.Connection.Open();

                string cmd = String.Format("update tiketi set ulog = '{0}' where id = {1}", ulog.ToString(CultureInfo.InvariantCulture), entitet.ID);
                c = new MySqlCommand(cmd, DAL.Connection);
                c.ExecuteNonQuery();

                DAL.Connection.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public List<Tiket> getAll()
        {
            throw new NotImplementedException();
        }
    }
}

using Kladionica.BazaPodataka.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kladionica.BazaPodataka
{
    public class IgraDAO : Interfejsi.IDaoCrud<Igra>
    {
        protected MySqlCommand c;
        public long create(Igra entity)
        {
            if ((entity as FudbalskaUtakmica) != null)
                return DAL.Factory.getFudbalskaUtakmicaDao().create(entity as FudbalskaUtakmica);

            else if((entity as Tenis) != null)
                return DAL.Factory.getTenisDao().create(entity as Tenis);

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
            throw new NotImplementedException();
        }

        public List<Igra> getByExample(string name, string value)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica.BazaPodataka
{
    public class DAOFactory
    {
        public static DAOFactory Instance
        {
            get
            {
                if (_instance == null) _instance = new DAOFactory();
                return _instance; 
            }
        }

        private static DAOFactory _instance;


        public Entiteti.FudbalskaUtakmicaDAO getFudbalskaUtakmicaDao()
        {
            return new Entiteti.FudbalskaUtakmicaDAO();
        }

        public TenisDAO getTenisDao()
        {
            return new TenisDAO();
        }
    }
}

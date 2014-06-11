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


        public FudbalskaUtakmicaDAO getFudbalskaUtakmicaDao()
        {
            return new FudbalskaUtakmicaDAO();
        }

        public TenisDAO getTenisDao()
        {
            return new TenisDAO();
        }

        public IgraDAO getIgraDao()
        {
            return new IgraDAO();
        }

        public RadnicaDAO getRadnicaDAO()
        {
            return new RadnicaDAO();
        }

        public PonudaDAO getPonudaDAO()
        {
            return new PonudaDAO();
        }

        public KoeficijentDAO getKoeficijentDAO()
        {
            return new KoeficijentDAO();
        }

        public TransakcijaDAO getTransakcijaDAO()
        {
            return new TransakcijaDAO();
        }

        public ClanKlubaDAO getClanKlubaDao()
        {
            return new ClanKlubaDAO();
        }

        public TiketDAO getTiketDAO()
        {
            return new TiketDAO();
        }
    }
}

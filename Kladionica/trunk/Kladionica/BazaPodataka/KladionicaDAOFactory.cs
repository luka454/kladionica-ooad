using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica.BazaPodataka
{
    public class DAOFactory
    {
        private DAOFactory _instance;

        public DAOFactory Instance
        {
            get
            {
                if (_instance == null) _instance = new DAOFactory();
                return _instance; 
            }
        }
        

        public static DAOFactory Instace()
        {
            throw new NotImplementedException();
        }
    }
}

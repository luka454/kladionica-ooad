using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica.BazaPodataka
{
    public class KladionicaDAOFactory
    {
        private KladionicaDAOFactory _instance;

        public KladionicaDAOFactory Instance
        {
            get
            {
                if (_instance == null) _instance = new KladionicaDAOFactory();
                return _instance; 
            }
        }
        

        public static KladionicaDAOFactory Instace()
        {
            throw new NotImplementedException();
        }
    }
}

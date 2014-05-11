using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Kladionica.BazaPodataka
{
    public partial class DAL
    {
        public DAOFactory Factory
        {
            get { return DAOFactory.Instance; }
        }
        public static DAL Instance
        {
            get
            {
                if (_instance == null) _instance = new DAL();

                return _instance;
            }
        }
        public static MySqlConnection Con
        {
            get
            {
                return Instance._con;
            }
        }


        public void kreirajTabele()
        {
            throw new NotImplementedException();
        }

    }
}

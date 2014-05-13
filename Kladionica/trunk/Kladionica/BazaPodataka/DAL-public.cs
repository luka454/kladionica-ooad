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
        /*
         * gives you factory for DAO classes
         */
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

        /*
         * gives you connection to datebase
         */
        public static MySqlConnection Connection
        {
            get
            {
                return DAL.Instance._con;
            }
        }


    }
}

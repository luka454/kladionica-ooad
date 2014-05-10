using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kladionica.BazaPodataka
{
    public class KladionicaDAL
    {
        public MySqlConnection con;
        public KladionicaDAOFactory Factory
        {
            get { return KladionicaDAOFactory.Instace(); }
        }
        public static KladionicaDAL Instance 
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KladionicaDAL();
                }
                return _instance;
            } 
        }


        public void kreirajTabele()
        {
            throw new NotImplementedException();
        }


        private KladionicaDAL()
        {
            _user = "root";
            _password = "";
            _database = "dao";

            String conString = String.Format("server=localhost;user={0};password={1};database={2}",_user,_password,_database);
            con = new MySqlConnection(conString);

        }

        private KladionicaDAL(string user, string password, string database)
        {
            _user = user;
            _password = password;
            _database = database;

            String conString = String.Format("server=localhost;user={0};password={1};database={2}", _user, _password, _database);
            con = new MySqlConnection(conString);
        }


        private String _user = "root";
        private String _password = "";
        private String _database = "dao";
        private static KladionicaDAL _instance;
                
    }
}

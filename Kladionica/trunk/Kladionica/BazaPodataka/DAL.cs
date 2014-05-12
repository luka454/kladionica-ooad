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
        private DAL()
        {
            _user = "root";
            _password = "";
            _database = "dao";

            String conString = String.Format("server=localhost;user={0};password={1};database={2};",_user,_password,_database);
            _con = new MySqlConnection(conString);

        }

        private DAL(string user, string password, string database)
        {
            _user = user;
            _password = password;
            _database = database;

            String conString = String.Format("server=localhost;user={0};password={1};database={2};", _user, _password, _database);
            _con = new MySqlConnection(conString);
        }


        private String _user = "root";
        private String _password = "";
        private String _database = "dao";
        private static MySqlConnection _con;
        private static DAL _instance;
                
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public class Radnica: Osoba
    {
        public override int Password
        {
            get { return _hashPassword; }
            set { _hashPassword = value; }
        }

        public override string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public override string Prezime
        {
            get { return _prezime; }
            set { _prezime = value; }
        }

        public override string Ime
        {
            get { return _ime; }
            set { _ime = value; }
        }

        public override int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public decimal Platu
        {
            get { return _plata; }
            set { _plata = value; }
        }

        public Boolean ProvjeriUsernameRadnice(string username) { return false; }
        public Boolean ProvjeriPassRadnice(int pass) { return false; }
    }
}

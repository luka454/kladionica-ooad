using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public class Osoba
    {
        protected int _ID;
        protected string _ime;
        protected string _prezime;
        protected string _username;
        protected int _hashPassword;

        public int DajPassword
        {
            get { return _hashPassword; }
            set { _hashPassword = value; }
        }

        public string DajUsername
        {
            get { return _username; }
            set { _username = value; }
        }

        public string DajPrezime
        {
            get { return _prezime; }
            set { _prezime = value; }
        }

        public string DajIme
        {
            get { return _ime; }
            set { _ime = value; }
        }

        public int DajID
        {
            get { return _ID; }
            set { _ID = value; }
        }
    }
}

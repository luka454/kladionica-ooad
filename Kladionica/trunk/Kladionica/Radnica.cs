using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public class Radnica: Osoba
    {
        private decimal _plata;

        public override int DajPassword
        {
            get { return _hashPassword; }
            set { _hashPassword = value; }
        }

        public override string DajUsername
        {
            get { return _username; }
            set { _username = value; }
        }

        public override string DajPrezime
        {
            get { return _prezime; }
            set { _prezime = value; }
        }

        public override string DajIme
        {
            get { return _ime; }
            set { _ime = value; }
        }

        public override int DajID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public decimal DajPlatu
        {
            get { return _plata; }
            set { _plata = value; }
        }

        public Boolean ProvjeriUsernameRadnice(string username) { return false; }
        public Boolean ProvjeriPassRadnice(int pass) { return false; }
    }
}

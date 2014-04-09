using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public abstract class Osoba
    {
        protected int _ID;
        protected string _ime;
        protected string _prezime;
        protected string _username;
        protected int _hashPassword;

        public int DajPassword{ get; set; }
        public string DajUsername{ get; set; }
        public string DajPrezime{ get; set; }
        public string DajIme{ get; set; }
        public int DajID{ get; set; }
    }
}

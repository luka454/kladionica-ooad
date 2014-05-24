using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public abstract class Osoba
    {
        public int HashPassword{ get; set; }
        public string Username{ get; set; }
        public string Prezime{ get; set; }
        public string Ime{ get; set; }
        public int ID{ get; set; }

        public Osoba(string ime, string prezime, string username, int hashpassword)
        {
            Ime = ime;
            Prezime = prezime;
            Username = username;
            HashPassword = hashpassword;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public class Radnica : Osoba 
    { 
        public Decimal Plata { get; set; }

        public Radnica(string ime, string prezime, string username, int hashpassword, decimal plata)
            : base(ime, prezime, username, hashpassword)
        {
            Plata = plata;
        }
        public Boolean ProvjeriUsernameRadnice(string username) {
            return Username.ToLower().Equals(username.ToLower());
        } 
        public Boolean ProvjeriPassRadnice(int hash_pass) {
            return hash_pass == HashPassword;
        } 
    }
}

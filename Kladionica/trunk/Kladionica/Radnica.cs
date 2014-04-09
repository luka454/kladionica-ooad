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
        public Boolean ProvjeriUsernameRadnice(string username) { return false; } 
        public Boolean ProvjeriPassRadnice(int pass) { return false; } 
    }
}

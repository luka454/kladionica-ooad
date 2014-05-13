using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public class Transakcija 
    {
	    public int ID;
	    public DateTime Vrijeme ;
	    public Decimal Iznos ;
	    public ClanKluba KojiKorisnik ;

        public Transakcija(DateTime v, decimal i, ClanKluba k)
        {
            Vrijeme = v;
            Iznos = i;
            KojiKorisnik = k;
        }
    }

}

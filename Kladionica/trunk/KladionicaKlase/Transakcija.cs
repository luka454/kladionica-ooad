using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaKlase
{
    public class Transakcija 
    {
	    public int ID;
	    public DateTime Vrijeme ;
	    public Decimal Iznos ;
	    public ClanKluba KojiKorisnik ;

        public Transakcija(int id, DateTime v, decimal i, ClanKluba k)
        {
            ID = id;
            Vrijeme = v;
            Iznos = i;
            KojiKorisnik = k;
        }
    }

}

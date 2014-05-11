using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    class Administracija
    {
        public Decimal DnevniBilans ;
	    public String AdminUsername ;
	    public int AdminHashPass;
	    public List<Radnica> Radnici;
        public Administracija(decimal db, string au, int ahp)
        {
            DnevniBilans = db;
            AdminUsername = au;
            AdminHashPass = ahp;
            Radnici = new List<Radnica>();
        }
	    private long HashPassFunkcija(String lozinka)
        {
            long hash = 5381;
            for (int i = 0; i < lozinka.Length; i++) hash = ((hash << 5) + hash) + lozinka[i];
            return hash;
        }
	    public Boolean NoviTiket(Tiket noviTiket) { return false; }
        public Boolean NovaIgra(Igra novaIgra) { return false; }
        public Boolean DodajRadnika(Radnica noviRadnik) { return false; }
        public Decimal IsplatiTiket(Tiket tiket) { return 0; }
	    private void AzurirajBilans(){}
        public Boolean OtpustiRadnika(Radnica radnik) { return false; }
        public Boolean UplatiTiket(Tiket tiket, Decimal iznos) { return true; }
        public Decimal IsplatiPlati(Radnica radnik) { return 0; }
        public int DodajClanaKluba(ClanKluba user) { return 0; }
        public Boolean IspisiClanaKluba(ClanKluba user) { return true; }
        public Boolean UplatiNovacNaClansku(int userID, Decimal iznos) { return true; }
        public Boolean IsplatiNovacSaRacuna(int UserId, Decimal iznos) { return true; }
    }
}

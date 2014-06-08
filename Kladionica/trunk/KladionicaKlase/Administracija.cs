using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaKlase
{
    class Administracija
    {
        public Decimal DnevniBilans ;
	    public String AdminUsername ;
	    public int AdminHashPass;
	    public List<Radnica> Radnici;
        public List<ClanKluba> ClanoviKluba;
        public List<Tiket> Tiketi;
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
	    public void NoviTiket(Tiket noviTiket) 
        {
            Tiketi.Add(noviTiket);
        }
        public Boolean NovaIgra(Igra novaIgra) 
        {
            return false;
        }
        public void DodajRadnika(Radnica noviRadnik) 
        {
            Radnici.Add(noviRadnik);
        }
        public Transakcija IsplatiTiket(Tiket tiket) 
        {
            //pobrini se za id 
            if (tiket.JelDobitni())
            {
                AzurirajBilans(-tiket.UkupniKoeficijent * tiket.Ulog);
                return new Transakcija(0, DateTime.Now, tiket.UkupniKoeficijent * tiket.Ulog);
            }
            
            throw new Exception("Nije dobitni");
        }
	    private void AzurirajBilans(decimal p)
        {
            DnevniBilans += p;
        }
        public void OtpustiRadnika(Radnica radnik) 
        {
            Radnici.Remove(radnik);
        }
        public void UplatiTiket(Tiket tiket, Decimal iznos) 
        {
            Tiketi.Add(tiket);
            AzurirajBilans(iznos);
        }
        public Decimal IsplatiPlati(Radnica radnik) 
        {
            AzurirajBilans(-radnik.Plata);
            return radnik.Plata;
        }
        public void DodajClanaKluba(ClanKluba user) 
        {
            ClanoviKluba.Add(user);
        }
        public void IspisiClanaKluba(ClanKluba user) 
        {
            ClanoviKluba.Remove(user);  
        }
        public Boolean UplatiNovacNaClansku(int userID, Decimal iznos) 
        {
            ClanKluba k = null;
            foreach (ClanKluba ck in ClanoviKluba) if (ck.ID == userID) k = ck;

            if (k == null) return false;
            //k.UplatiNovac(iznos);
            return true;
        }
        public Boolean IsplatiNovacSaRacuna(int UserId, Decimal iznos) 
        {
            ClanKluba k = null;
            foreach (ClanKluba ck in ClanoviKluba) if (ck.ID == UserId) k = ck;

            if (k == null) return false;
            //k.IsplatiNovac(iznos);
            return true;
        }
    }
}

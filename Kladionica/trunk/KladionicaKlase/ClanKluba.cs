using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaKlase
{
    public class ClanKluba: Osoba
    {
        public decimal DajNovac { get; set; }
        public int DajPIN { get; set; }

        private List<Tiket> _tiketi = new List<Tiket>();

        private long HashPassFunkcija(string lozinka)
        {
            long hash = 5381;
            for (int i = 0; i < lozinka.Length; i++) hash = ((hash << 5) + hash) + lozinka[i];
            return hash;
        }
        public ClanKluba(int id, string i, string p, string u, int hp): base(id,i,p,u,hp){ }

        static public int HashFunkcijaPassword(int pin) { return 0; }
        static public string HashFunkcijaSifra(string pass) { return pass; }
        public Boolean UplatiTiket(Tiket noviTiket, decimal pare) { return false; }
        public decimal IsplatiTiket(Tiket odigraniTiket) { return 0; }
        public List<Tiket> DajSveTikete() { return _tiketi; }
        public List<Tiket> DajDobitneTikete() { return _tiketi; }
        public Boolean PromijeniPIN(int noviPIN) { return false; }
        public Boolean PromijeniSifru(string NovaSifra) { return false; }

        internal void UplatiNovac(decimal iznos)
        {
            throw new NotImplementedException();
        }

        internal void IsplatiNovac(decimal iznos)
        {
            throw new NotImplementedException();
        }
    }
}

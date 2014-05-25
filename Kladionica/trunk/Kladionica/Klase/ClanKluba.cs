using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public class ClanKluba: Osoba
    {
        private List<Tiket> _tiketi = new List<Tiket>();
        public ClanKluba(string i, string p, string u, int hp) : base(i, p, u, hp) { }

        public decimal Novac { get; set; }   
        public int PIN { get; set; }

        public void UplatiNovac(decimal pare) {
            Novac += pare;
        }
        public Boolean IsplatiNovac(decimal pare) {
            if (Novac < pare) return false;
            Novac -= pare;
            return true;
        }
        public Boolean ProvjeriPIN(int pin) {
            return PIN == pin;
        }
        public Boolean ProvjeriSifru(String pass) {
            return HashFunkcijaSifra(pass) == HashPassword;
        }
        static public int HashFunkcijaSifra(String pass) {
            return Convert.ToInt32(pass); 
        }
        public void UplatiTiket(Tiket noviTiket, decimal pare) {
            noviTiket.Ulog = pare;
        }
        public decimal IsplatiTiket(Tiket odigraniTiket) {
            return odigraniTiket.UkupniDobitak();
        }
        public List<Tiket> DajSveTikete() { 
            return _tiketi;
        }
        public List<Tiket> DajDobitneTikete() {
            List<Tiket> dobitni=new List<Tiket>();
            foreach (Tiket t in _tiketi)
            {
                if (t.JelDobitni())
                    dobitni.Add(t);
            }
            return dobitni;
        }
        public Boolean PromijeniPIN(int stariPIN, int noviPIN) {
            if (PIN == stariPIN) 
            {
                PIN = noviPIN;
                return true;
            }
            return false;
        }
        public Boolean PromijeniSifru(String staraSifra, String novaSifra) {
            if (HashFunkcijaSifra(staraSifra) == HashPassword)
            {
                HashPassword = HashFunkcijaSifra(novaSifra);
                return true;
            }
            return false;
        }
        /*
        public Transakcija UplatiNovac(decimal pare)
        {
            return new Transakcija(0, DateTime.Now, pare, this);
        }
        public Transakcija IsplatiNovac(decimal pare)
        {
            return new Transakcija(0, DateTime.Now, -pare, this);
        }
        
         // vjerujem da ce i ovo zatrebat kasnije */
    }
}

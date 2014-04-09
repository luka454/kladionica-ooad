using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public class ClanKluba: Osoba
    {
        public decimal DajNovac { get; set; }   
        public int DajPIN { get; set; }
        public void UplatiNovac(decimal pare) { }
        public Boolean IsplatiNovac(decimal pare) { return false; }
        public Boolean ProvjeriPIN(int pin) { return false; }
        public Boolean ProvjeriSifru(string pass) { return false; }
        static public int HashFunkcijaPassword(int pin) { return 0; }
        static public string HashFunkcijaSifra(string pass) { return pass; }
        public Boolean UplatiTiket(Tiket noviTiket, decimal pare) { return false; }
        public decimal IsplatiTiket(Tiket odigraniTiket) { return 0; }
        public List<Tiket> DajSveTikete() { return _tiketi; }
        public List<Tiket> DajDobitneTikete() { return _tiketi; }
        public Boolean PromijeniPIN(int noviPIN) { return false; }
        public Boolean PromijeniSifru(string NovaSifra) { return false; }   
    }
}

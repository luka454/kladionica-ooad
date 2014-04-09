using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public class ClanKluba: Osoba
    {
        private int _PIN;
        private decimal _novac;

        public override int DajPassword
        {
            get { return _hashPassword; }
            set { _hashPassword = value; }
        }

        public override string DajUsername
        {
            get { return _username; }
            set { _username = value; }
        }

        public override string DajPrezime
        {
            get { return _prezime; }
            set { _prezime = value; }
        }

        public override string DajIme
        {
            get { return _ime; }
            set { _ime = value; }
        }

        public override int DajID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public decimal DajNovac
        {
            get { return _novac; }
            set { _novac = value; }
        }        

        public int DajPIN
        {
            get { return _PIN; }
            set { _PIN = value; }
        }

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
        public Boolean PromijeniPIN(int noviPIN) { return 0; }
        public Boolean PromijeniSifru(string NovaSifra) { return false;     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public class Tenis : Igra
    {
        public String PrviProtivnik { get; set; }
        public String DrugiProtivnik { get; set; }
        public int PrviPoenaSetova { get; set; }
        public int DrugiPoenaSetova { get; set; }
        public Tenis(DateTime p, string n, StatusIgre si, string pp, string dp, int pps = 0, int dps = 0) : base(p, n, si)
        {
            PrviProtivnik = pp;
            DrugiProtivnik = dp;
            PrviPoenaSetova = pps;
            DrugiPoenaSetova = dps;
        }
        /*public String PrviProtivnik { get; set; }
        public String DrugiProtivnik { get; set; }
        public int PrviPoenaSetova { get; set; }
        public int DrugiPoenaSetova { get; set; }
        public int PrviPoenaGemova { get; set; }
        public int DrugiPoenaGemova { get; set; }
        public Tenis(int id, DateTime p, string n, StatusIgre si, string pp, string dp, int pps, int dps, int ppg, int dpg)
            : base(id, p, n, si)
        {
            PrviProtivnik = pp;
            DrugiProtivnik = dp;
            PrviPoenaSetova = pps;
            DrugiPoenaSetova = dps;
            PrviPoenaGemova = ppg;
            DrugiPoenaGemova = dpg;
        }*/
        //ne moze ovo ja mislim samo sa setovima u tenisu
        public override bool ProvjeriTip(String tip)
        {
            return (tip == "1" || tip == "2");
        }
        
        public override bool ProvjeriJeLiDobitni(String tip)
        {
            if (tip == "1")
                return PrviPoenaSetova > DrugiPoenaSetova;
            else if (tip == "2")
                return DrugiPoenaSetova > PrviPoenaSetova;
            else
                throw new Exception("Odigrani tip nije validan");

        }
    }
}

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
        public Tenis(DateTime p, string n, StatusIgre si, string pp, string dp, int pps, int dps) : base(p, n, si)
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
            foreach (Koeficijent k in koeficijenti) if (tip == k.tip) return true;
            return false;
        }
        
        public override bool ProvjeriJeLiDobitni(String tip)
        {
            /* ovo sam zakomentirala, jer se ne moze buildat zbog ovog k.Dobitni
            foreach (Koeficijent k in koeficijenti) if (tip == k.tip) return k.Dobitni;
            throw new Exception("Nije validan tip!");*/
            return true;
        }
    }
}

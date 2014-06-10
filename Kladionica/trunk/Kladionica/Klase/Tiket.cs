using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public class Tiket
    {
        public List<StavkaTiketa> OdigraneIgre { get; set; }
        public decimal UkupniKoeficijent { get; set; }
        public decimal Ulog { get; set; }
        public TipTiketa TipTiketa { get; set; }
        public int ID { get; set; }
        public ClanKluba Vlasnik { get; set; }
        public Tiket(decimal uk, decimal ul, TipTiketa tt)
        {
            UkupniKoeficijent = uk;
            Ulog = ul;
            TipTiketa = tt;
            OdigraneIgre = new List<StavkaTiketa>();
        }
        public decimal UkupniDobitak() 
        {
            return UkupniKoeficijent * Ulog;
        }
        public Boolean JelDobitni() 
        {
            //Javi luki da moze ovo ljepse vako je previse rovokopacki
            List<StavkaTiketa> dobitniParovi=new List<StavkaTiketa>();
            List<StavkaTiketa> fiksniParovi = new List<StavkaTiketa>();
            if (TipTiketa.ToString() == "Normalni")
            {
                foreach (StavkaTiketa oi in OdigraneIgre)
                {
                    if (oi.JeLiDobitni())
                        dobitniParovi.Add(oi);
                }
                if (OdigraneIgre.Count == dobitniParovi.Count)
                    return true;
                return false;
            }
            else if (TipTiketa.ToString() == "Sistem")
            {
                foreach (StavkaTiketa oi in OdigraneIgre)
                {
                    if (oi.JeLiDobitni())
                        dobitniParovi.Add(oi);
                }

            }
            else if (TipTiketa.ToString() == "Fiksni")
            {
                int brojac = 0;
                foreach (StavkaTiketa oi in OdigraneIgre)
                {
                    if (oi.JeLiFiksni())
                        fiksniParovi.Add(oi);
                    if (oi.JeLiDobitni())
                        dobitniParovi.Add(oi);
                }
                foreach (StavkaTiketa dp in dobitniParovi)
                {
                    if (dp.JeLiFiksni())
                        brojac++;
                }
                if (brojac == fiksniParovi.Count)
                    return true;
                return false;
            }
            return false;
        }
        public List<StavkaTiketa> DajIgre() 
        { 
            return OdigraneIgre;
        }
        public List<StavkaTiketa> DajDobitneIgre() 
        {
            List<StavkaTiketa> dobitne = new List<StavkaTiketa>();
            foreach (StavkaTiketa oi in OdigraneIgre)if (oi.JeLiDobitni()) dobitne.Add(oi);
            return dobitne;
        }

        public void ProracujaUkupniKoeficijent()
        {
            UkupniKoeficijent = 1;
            foreach (var item in this.OdigraneIgre)
            {
                UkupniKoeficijent *= item.Koeficijent();
            }
        }
    }
}

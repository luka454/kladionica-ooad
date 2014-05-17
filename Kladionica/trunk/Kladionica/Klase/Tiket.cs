﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public class Tiket
    {
        private List<StavkaTiketa> OdigraneIgre { get; set; }
        public decimal UkupniKoeficijent { get; set; }
        public decimal Ulog { get; set; }
        public TipTiketa TipTiketa { get; set; }
        public int ID { get; set; }

        public Tiket(decimal uk, decimal ul, TipTiketa tt)
        {
            UkupniKoeficijent = uk;
            Ulog = ul;
            TipTiketa = tt;
            OdigraneIgre = new List<StavkaTiketa>();
        }
        public decimal UkupniDobitak() {
            return UkupniKoeficijent * Ulog;
        }
        public Boolean JelDobitni() {
            List<StavkaTiketa> dobitniParovi=new List<StavkaTiketa>();
            if (TipTiketa.ToString()=="Normalni") {
                foreach (StavkaTiketa oi in OdigraneIgre) {
                    if (oi.JeLiDobitni())
                        dobitniParovi.Add(oi);
                }
                if (OdigraneIgre.Count == dobitniParovi.Count)
                    return true;
                return false;
            }
            else if (TipTiketa.ToString() == "Sistem") {
                foreach (StavkaTiketa oi in OdigraneIgre) {
                    if (oi.JeLiDobitni())
                        dobitniParovi.Add(oi);
                }

            }
            else if (TipTiketa.ToString() == "Fiksni") {
                
            }
        }
        public List<StavkaTiketa> DajIgre() { return OdigraneIgre; }
        public List<StavkaTiketa> DajDobitneIgre() { return OdigraneIgre; }
    }
}

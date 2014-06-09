﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class Igra49 : Igra
    {
        public int ID { get; set; }
        public Tiket6 Tiket { get; set; }
        public int TrenutniBroj { get; set; }
        public List<int> MoguciBrojevi { get; set; }

        public Igra49()
        {
            Tiket = new Tiket6();
            MoguciBrojevi = new List<int>();
            for (int i = 1; i <= 49; i++)
                MoguciBrojevi.Add(i);
        }
        public int DajSljedeciBroj()
        {
            Random rand = new Random();
            int tempBroj, br;            
            tempBroj = rand.Next(0, MoguciBrojevi.Count);
            br = MoguciBrojevi[tempBroj];
            TrenutniBroj = br;
            MoguciBrojevi.RemoveAt(tempBroj);
            return br;
        }
        public void DodajObserver(Tiket6 t)
        {
            //OdigraniTiketi.Add(t);
        }
        public void IzbrisiObserver(Tiket6 t)
        {
            //OdigraniTiketi.Remove(t);
        }
        public void Obavijesti()
        {
            Tiket.Obavijesti(TrenutniBroj);
        }
    }
}

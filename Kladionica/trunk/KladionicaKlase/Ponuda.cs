﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaKlase
{
    public class Ponuda
    {
        public DateTime Datum { get; set; }
        public List<Igra> IgreUPonudi { get; set; }

        public Ponuda()
        {
            Datum = DateTime.Today;
            IgreUPonudi = new List<Igra>();
        }

        public Ponuda(DateTime datum)
        {
            Datum = datum;
            IgreUPonudi = new List<Igra>();
        }

        public void printaj() { 
            //TODO: implementirati direktno printanje na printer
        }
    }
}

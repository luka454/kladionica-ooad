﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public class Tiket
    {
        public decimal UkupniKoeficijent { get; set; }
        public decimal Ulog { get; set; }
        public tipTiketa TipTiketa { get; set; }
        public int ID { get; set; } 
        public Boolean JelDobitni() { return false; }
        public List<StavkaTiketa> DajIgre() { return _odigraneIgre }
        public List<StavkaTiketa> DajDobitneIgre() { return _dobitneIgre }
    }
}

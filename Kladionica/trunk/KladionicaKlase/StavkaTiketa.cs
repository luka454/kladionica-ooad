﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaKlase
{
    public class StavkaTiketa
    {
        public String OdigraniTip { get; set; }
        public Igra OdigranaIgra { get; set; }

        public Boolean JeLiDobitni()
        {
            return OdigranaIgra.ProvjeriJeLiDobitni(OdigraniTip);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bingo
{
    public class Kuglice : Button
    {
        public bool IsSelected { get; set; }
        public string Boja { get; set; }
        public int Broj { get; set; }
        public Kuglice() {
            IsSelected = false;
        }
    }

    
}

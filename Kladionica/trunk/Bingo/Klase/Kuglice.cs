using System;
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
        public string OdrediBoju(int br)
        {
            for (int i = 0; i < 49; i+=7)
                if (br == i + 1) return Boja = "Crvene";
            for (int i = 1; i < 49; i += 7)
                if (br == i + 1) return Boja = "Zute";
            for (int i = 2; i < 49; i += 7)
                if (br == i + 1) return Boja = "Plave";
            for (int i = 3; i < 49; i += 7)
                if (br == i + 1) return Boja = "Narandzaste";
            for (int i = 4; i < 49; i += 7)
                if (br == i + 1) return Boja = "Zelene";
            for (int i = 5; i < 49; i += 7)
                if (br == i + 1) return Boja = "Roze";
            for (int i = 6; i < 49; i += 7)
                if (br == i + 1) return Boja = "Ljubicaste";
            return null;
        }
    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class Tiket6 : ITiket
    {
        public int ID { get; set; }
        public List<int> Brojevi { get; set; }
        public int Brojac { get; set; }

        public Tiket6() {
            Brojevi = new List<int>();
            Brojevi.Capacity = 6;
            Brojac = 0;
        }
        public void ProvjeriBrojeve() 
        {
            for (int i = 0; i < 6; i++)
            {
                if (Brojevi[i] < 1 || Brojevi[i] > 49) throw new Exception("Brojevi moraju biti u opsegu od 1 do 49!");
                for (int j = i + 1; j < 6; j++)
                    if (Brojevi[i] == Brojevi[j]) throw new Exception("Ne smiju se ponavljati brojevi!");
            }
        }
        public void ObrisiBrojeve() {
            while (Brojevi.Count != 0) Brojevi.RemoveAt(0);
        }
        public void SortirajBrojeve() {
            Brojevi.Sort();
        }
        public bool JelDobitni() {
            if (Brojac == 6) return true;
            return false;
        }
        public bool Obavijesti(int broj) {
            foreach (int br in Brojevi)
                if (br == broj)
                    return true;
            return false;
        }
    }
}

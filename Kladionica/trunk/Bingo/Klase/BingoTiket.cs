using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class BingoTiket
    {
        public int ID { get; set; }
        public List<int> Brojevi { get; set; }

        public BingoTiket() {
            Brojevi = new List<int>();
            Brojevi.Capacity = 6;
        }
        public void UpisiBrojeve(List<int> brojevi)
        {
            if (brojevi.Count > 6) throw new Exception("Ne smije biti vise od 6 brojeva!");
            for (int i = 0; i < 6; i++)
                for (int j = i+1; j < 6; j++)
                    if (brojevi[i] == brojevi[j]) throw new Exception("Ne smiju se ponavljati brojevi!");

            foreach (int broj in brojevi) {
                Brojevi.Add(broj);
            }
        }
        public BingoTiket KreirajTiket()
        {
            
        }
    }
}

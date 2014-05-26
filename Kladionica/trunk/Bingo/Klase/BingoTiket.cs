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
            foreach (int broj in brojevi){
                Brojevi.Add(broj);
            }
        }
        public BingoTiket KreirajTiket()
        {
            
        }
    }
}

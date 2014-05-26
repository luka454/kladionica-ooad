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
        public void UpisiBrojeve(List<int> brojevi) {
            if (brojevi.Count > 6) throw new Exception("Ne smije biti vise od 6 brojeva!");
            for (int i = 0; i < 6; i++) {
                if (brojevi[i] < 1 || brojevi[i] > 49) throw new Exception("Brojevi moraju biti u opsegu od 1 do 49!");
                for (int j = i + 1; j < 6; j++)
                    if (brojevi[i] == brojevi[j]) throw new Exception("Ne smiju se ponavljati brojevi!");
            }

            foreach (int broj in brojevi) {
                Brojevi.Add(broj);
            }
        }
        public void ObrisiBrojeve() {
            foreach (int broj in Brojevi){
                Brojevi.Remove(broj);
            }
        }
        public void SortirajBrojeve() {
            Brojevi.Sort();
        }
        public BingoTiket DajAutomatski() {
            BingoTiket t = new BingoTiket();
            List<int> brojevi = new List<int>();
            // ovo je primjer samo
            for (int i = 0; i < 6; i++) {
                int j=5;
                brojevi[i] = j;
                j += 5;
            }
            t.UpisiBrojeve(brojevi);
            t.SortirajBrojeve();
            return t;
        }
        public BingoTiket DajCrvene() {
            BingoTiket t = new BingoTiket();
            List<int> brojevi = new List<int>();
            for (int i = 0; i < 6; i++) {
                int j = 1;
                brojevi[i] = j;
                j += 7;
            }
            t.UpisiBrojeve(brojevi);
            t.SortirajBrojeve();
            return t;
        }
        public BingoTiket DajZute()
        {
            BingoTiket t = new BingoTiket();
            List<int> brojevi = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                int j = 2;
                brojevi[i] = j;
                j += 7;
            }
            t.UpisiBrojeve(brojevi);
            t.SortirajBrojeve();
            return t;
        }
        public BingoTiket DajPlave()
        {
            BingoTiket t = new BingoTiket();
            List<int> brojevi = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                int j = 3;
                brojevi[i] = j;
                j += 7;
            }
            t.UpisiBrojeve(brojevi);
            t.SortirajBrojeve();
            return t;
        }
        public BingoTiket DajNarandzaste()
        {
            BingoTiket t = new BingoTiket();
            List<int> brojevi = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                int j = 4;
                brojevi[i] = j;
                j += 7;
            }
            t.UpisiBrojeve(brojevi);
            t.SortirajBrojeve();
            return t;
        }
        public BingoTiket DajZelene()
        {
            BingoTiket t = new BingoTiket();
            List<int> brojevi = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                int j = 5;
                brojevi[i] = j;
                j += 7;
            }
            t.UpisiBrojeve(brojevi);
            t.SortirajBrojeve();
            return t;
        }
        public BingoTiket DajRoze()
        {
            BingoTiket t = new BingoTiket();
            List<int> brojevi = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                int j = 6;
                brojevi[i] = j;
                j += 7;
            }
            t.UpisiBrojeve(brojevi);
            t.SortirajBrojeve();
            return t;
        }
        public BingoTiket DajLjubicaste()
        {
            BingoTiket t = new BingoTiket();
            List<int> brojevi = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                int j = 7;
                brojevi[i] = j;
                j += 7;
            }
            t.UpisiBrojeve(brojevi);
            t.SortirajBrojeve();
            return t;
        }
    }
}

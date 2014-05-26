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
            foreach (int broj in Brojevi) {
                Brojevi.Remove(broj);
            }
        }
        public void SortirajBrojeve() {
            Brojevi.Sort();
        }
        public BingoTiket DajAutomatski() 
        {
            BingoTiket t = new BingoTiket();
            // ovo je primjer samo
            for (int i = 0; i < 6; i++) {
                int j = 5;
                t.Brojevi[i] = j;
                j += 5;
            }
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            return t;
        }
        // ima 7 kuglica svake boje, a samo 6 mogu na listic, pa je ovaj broj koji zele izbaciti
        public BingoTiket DajCrvene(int broj) 
        {
            if (broj != 1 && broj != 8 && broj != 15 && broj != 22 && broj != 29 && broj != 36 && broj != 43)
                throw new Exception("Taj broj ne spada u crvene!");
            BingoTiket t = new BingoTiket();
            int j;
            for (int i = 0; i < 6; i++) {
                j = 1;
                if (j == broj)
                    j += 7;
                else {
                    t.Brojevi[i] = j;
                    j += 7;
                }
            }
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            return t;
        }
        public BingoTiket DajZute(int broj)
        {
            if (broj != 2 && broj != 9 && broj != 16 && broj != 23 && broj != 30 && broj != 37 && broj != 44)
                throw new Exception("Taj broj ne spada u zute!");
            BingoTiket t = new BingoTiket();
            int j;
            for (int i = 0; i < 6; i++)
            {
                j = 2;
                if (j == broj)
                    j += 7;
                else
                {
                    t.Brojevi[i] = j;
                    j += 7;
                }
            }
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            return t;
        }
        public BingoTiket DajPlave(int broj)
        {
            if (broj != 3 && broj != 10 && broj != 17 && broj != 24 && broj != 31 && broj != 38 && broj != 45)
                throw new Exception("Taj broj ne spada u plave!");
            BingoTiket t = new BingoTiket();
            int j;
            for (int i = 0; i < 6; i++)
            {
                j = 3;
                if (j == broj)
                    j += 7;
                else
                {
                    t.Brojevi[i] = j;
                    j += 7;
                }
            }
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            return t;
        }
        public BingoTiket DajNarandzaste(int broj)
        {
            if (broj != 4 && broj != 11 && broj != 18 && broj != 25 && broj != 32 && broj != 39 && broj != 46)
                throw new Exception("Taj broj ne spada u narandzaste!");
            BingoTiket t = new BingoTiket();
            int j;
            for (int i = 0; i < 6; i++)
            {
                j = 4;
                if (j == broj)
                    j += 7;
                else
                {
                    t.Brojevi[i] = j;
                    j += 7;
                }
            }
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            return t;
        }
        public BingoTiket DajZelene(int broj)
        {
            if (broj != 5 && broj != 12 && broj != 19 && broj != 26 && broj != 33 && broj != 40 && broj != 47)
                throw new Exception("Taj broj ne spada u plave!");
            BingoTiket t = new BingoTiket();
            int j;
            for (int i = 0; i < 6; i++)
            {
                j = 5;
                if (j == broj)
                    j += 7;
                else
                {
                    t.Brojevi[i] = j;
                    j += 7;
                }
            }
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            return t;
        }
        public BingoTiket DajRoze(int broj)
        {
            if (broj != 6 && broj != 13 && broj != 20 && broj != 27 && broj != 34 && broj != 41 && broj != 48)
                throw new Exception("Taj broj ne spada u roze!");
            BingoTiket t = new BingoTiket();
            int j;
            for (int i = 0; i < 6; i++)
            {
                j = 6;
                if (j == broj)
                    j += 7;
                else
                {
                    t.Brojevi[i] = j;
                    j += 7;
                }
            }
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            return t;
        }
        public BingoTiket DajLjubicaste(int broj)
        {
            if (broj != 7 && broj != 14 && broj != 21 && broj != 28 && broj != 35 && broj != 42 && broj != 49)
                throw new Exception("Taj broj ne spada u ljubicaste!");
            BingoTiket t = new BingoTiket();
            int j;
            for (int i = 0; i < 6; i++)
            {
                j = 7;
                if (j == broj)
                    j += 7;
                else
                {
                    t.Brojevi[i] = j;
                    j += 7;
                }
            }
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            return t;
        }
        public BingoTiket DajNormalni(List<int> brojevi)
        {
            if (brojevi.Count > 6) throw new Exception("Ne smije biti vise od 6 brojeva!");
            BingoTiket t = new BingoTiket();
            t.Brojevi=brojevi;
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            return t;
        }
    }
}

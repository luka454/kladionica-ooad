using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class TiketFactory
    {
        public TiketFactory OnlyInstance { get; set; }

        public TiketFactory() { }
        public static BingoTiket DajAutomatski()
        {         
            BingoTiket t = new BingoTiket();
            List<int> temp = new List<int>();
            Random rand = new Random();
            int tempBroj;
            for (int i = 1; i <= 49; i++)
                temp.Add(i);
            int granica = 49;
            for (int i = 0; i < 6; i++)
            {
                tempBroj = rand.Next(0, granica--);
                t.Brojevi[i] = temp[tempBroj];
                temp.RemoveAt(tempBroj);
            }
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            return t;
        }
        // ima 7 kuglica svake boje, a samo 6 mogu na listic, pa je ovo broj koji zele izbaciti
        public static BingoTiket DajCrvene(int broj)
        {
            if (broj != 1 && broj != 8 && broj != 15 && broj != 22 && broj != 29 && broj != 36 && broj != 43)
                throw new Exception("Taj broj ne spada u crvene!");
            BingoTiket t = new BingoTiket();
            int j = 1;
            for (int i = 0; i < 6; i++)
            {
                if (j == broj)
                {
                    j += 7;
                    i--;
                }
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
        public static BingoTiket DajZute(int broj)
        {
            if (broj != 2 && broj != 9 && broj != 16 && broj != 23 && broj != 30 && broj != 37 && broj != 44)
                throw new Exception("Taj broj ne spada u zute!");
            BingoTiket t = new BingoTiket();
            int j = 2;
            for (int i = 0; i < 6; i++)
            {
                if (j == broj)
                {
                    j += 7;
                    i--;
                }
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
        public static BingoTiket DajPlave(int broj)
        {
            if (broj != 3 && broj != 10 && broj != 17 && broj != 24 && broj != 31 && broj != 38 && broj != 45)
                throw new Exception("Taj broj ne spada u plave!");
            BingoTiket t = new BingoTiket();
            int j = 3;
            for (int i = 0; i < 6; i++)
            {
                if (j == broj)
                {
                    j += 7;
                    i--;
                }
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
        public static BingoTiket DajNarandzaste(int broj)
        {
            if (broj != 4 && broj != 11 && broj != 18 && broj != 25 && broj != 32 && broj != 39 && broj != 46)
                throw new Exception("Taj broj ne spada u narandzaste!");
            BingoTiket t = new BingoTiket();
            int j = 4;
            for (int i = 0; i < 6; i++)
            {
                if (j == broj)
                {
                    j += 7;
                    i--;
                }
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
        public static BingoTiket DajZelene(int broj)
        {
            if (broj != 5 && broj != 12 && broj != 19 && broj != 26 && broj != 33 && broj != 40 && broj != 47)
                throw new Exception("Taj broj ne spada u zelene!");
            BingoTiket t = new BingoTiket();
            int j = 5;
            for (int i = 0; i < 6; i++)
            {
                if (j == broj)
                {
                    j += 7;
                    i--;
                }
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
        public static BingoTiket DajRoze(int broj)
        {
            if (broj != 6 && broj != 13 && broj != 20 && broj != 27 && broj != 34 && broj != 41 && broj != 48)
                throw new Exception("Taj broj ne spada u roze!");
            BingoTiket t = new BingoTiket();
            int j = 6;
            for (int i = 0; i < 6; i++)
            {
                if (j == broj)
                {
                    j += 7;
                    i--;
                }
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
        public static BingoTiket DajLjubicaste(int broj)
        {
            if (broj != 7 && broj != 14 && broj != 21 && broj != 28 && broj != 35 && broj != 42 && broj != 49)
                throw new Exception("Taj broj ne spada u ljubicaste!");
            BingoTiket t = new BingoTiket();
            int j = 7;
            for (int i = 0; i < 6; i++)
            {
                if (j == broj)
                {
                    j += 7;
                    i--;
                }
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
        public static BingoTiket DajNormalni(List<int> brojevi)
        {
            if (brojevi.Count > 6) throw new Exception("Ne smije biti vise od 6 brojeva!");
            BingoTiket t = new BingoTiket();
            t.Brojevi = brojevi;
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            return t;
        }
    }
}

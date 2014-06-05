using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class TiketFactory
    {
        private static TiketFactory onlyInstance;
        public static Admin Administrator { get; set; }
        public TiketFactory() { }

        public static TiketFactory Instance() {
            Administrator = new Admin();
            if (onlyInstance == null)
                onlyInstance = new TiketFactory();
            return onlyInstance;
        }
        public static Tiket6 DajAutomatski()
        {       
            Tiket6 t = new Tiket6();
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
            Administrator.TrenutnaIgra.OdigraniTiketi.Add(t);
            return t;
        }
        // ima 7 kuglica svake boje, a samo 6 mogu na listic, pa je ovo broj koji zele izbaciti
        public static Tiket6 DajCrvene(int broj)
        {
            if (broj != 1 && broj != 8 && broj != 15 && broj != 22 && broj != 29 && broj != 36 && broj != 43)
                throw new Exception("Taj broj ne spada u crvene!");
            Tiket6 t = new Tiket6();
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
            Administrator.TrenutnaIgra.OdigraniTiketi.Add(t);
            return t;
        }
        public static Tiket6 DajZute(int broj)
        {
            if (broj != 2 && broj != 9 && broj != 16 && broj != 23 && broj != 30 && broj != 37 && broj != 44)
                throw new Exception("Taj broj ne spada u zute!");
            Tiket6 t = new Tiket6();
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
            Administrator.TrenutnaIgra.OdigraniTiketi.Add(t);
            return t;
        }
        public static Tiket6 DajPlave(int broj)
        {
            if (broj != 3 && broj != 10 && broj != 17 && broj != 24 && broj != 31 && broj != 38 && broj != 45)
                throw new Exception("Taj broj ne spada u plave!");
            Tiket6 t = new Tiket6();
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
            Administrator.TrenutnaIgra.OdigraniTiketi.Add(t);
            return t;
        }
        public static Tiket6 DajNarandzaste(int broj)
        {
            if (broj != 4 && broj != 11 && broj != 18 && broj != 25 && broj != 32 && broj != 39 && broj != 46)
                throw new Exception("Taj broj ne spada u narandzaste!");
            Tiket6 t = new Tiket6();
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
            Administrator.TrenutnaIgra.OdigraniTiketi.Add(t);
            return t;
        }
        public static Tiket6 DajZelene(int broj)
        {
            if (broj != 5 && broj != 12 && broj != 19 && broj != 26 && broj != 33 && broj != 40 && broj != 47)
                throw new Exception("Taj broj ne spada u zelene!");
            Tiket6 t = new Tiket6();
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
            Administrator.TrenutnaIgra.OdigraniTiketi.Add(t);
            return t;
        }
        public static Tiket6 DajRoze(int broj)
        {
            if (broj != 6 && broj != 13 && broj != 20 && broj != 27 && broj != 34 && broj != 41 && broj != 48)
                throw new Exception("Taj broj ne spada u roze!");
            Tiket6 t = new Tiket6();
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
            Administrator.TrenutnaIgra.OdigraniTiketi.Add(t);
            return t;
        }
        public static Tiket6 DajLjubicaste(int broj)
        {
            if (broj != 7 && broj != 14 && broj != 21 && broj != 28 && broj != 35 && broj != 42 && broj != 49)
                throw new Exception("Taj broj ne spada u ljubicaste!");
            Tiket6 t = new Tiket6();
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
            Administrator.TrenutnaIgra.OdigraniTiketi.Add(t);
            return t;
        }
        public static Tiket6 DajNormalni(List<int> brojevi)
        {
            if (brojevi.Count > 6) throw new Exception("Ne smije biti vise od 6 brojeva!");
            Tiket6 t = new Tiket6();
            t.Brojevi = brojevi;
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            Administrator.TrenutnaIgra.OdigraniTiketi.Add(t);
            return t;
        }
    }
}

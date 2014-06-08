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
                int index = i;
                tempBroj = rand.Next(0, granica--);
                t.Brojevi[index] = temp[tempBroj];
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
            t.Brojevi.Capacity = 7;
            t.Brojevi.Add(1);
            t.Brojevi.Add(8);
            t.Brojevi.Add(15);
            t.Brojevi.Add(22);
            t.Brojevi.Add(29);
            t.Brojevi.Add(36);
            t.Brojevi.Add(43);
            if (t.Brojevi.Contains(broj)) t.Brojevi.Remove(broj);
            t.Brojevi.Capacity = 6;
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            //Administrator.TrenutnaIgra.OdigraniTiketi.Add(t);
            return t;
        }
        public static Tiket6 DajZute(int broj)
        {
            if (broj != 2 && broj != 9 && broj != 16 && broj != 23 && broj != 30 && broj != 37 && broj != 44)
                throw new Exception("Taj broj ne spada u zute!");
            Tiket6 t = new Tiket6();
            t.Brojevi.Capacity = 7;
            t.Brojevi.Add(2);
            t.Brojevi.Add(9);
            t.Brojevi.Add(16);
            t.Brojevi.Add(23);
            t.Brojevi.Add(30);
            t.Brojevi.Add(37);
            t.Brojevi.Add(44);
            if (t.Brojevi.Contains(broj)) t.Brojevi.Remove(broj);
            t.Brojevi.Capacity = 6;
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            //Administrator.TrenutnaIgra.OdigraniTiketi.Add(t);
            return t;
        }
        public static Tiket6 DajPlave(int broj)
        {
            if (broj != 3 && broj != 10 && broj != 17 && broj != 24 && broj != 31 && broj != 38 && broj != 45)
                throw new Exception("Taj broj ne spada u plave!");
            Tiket6 t = new Tiket6();
            t.Brojevi.Capacity = 7;
            t.Brojevi.Add(3);
            t.Brojevi.Add(10);
            t.Brojevi.Add(17);
            t.Brojevi.Add(24);
            t.Brojevi.Add(31);
            t.Brojevi.Add(38);
            t.Brojevi.Add(45);
            if (t.Brojevi.Contains(broj)) t.Brojevi.Remove(broj);
            t.Brojevi.Capacity = 6;
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            //Administrator.TrenutnaIgra.OdigraniTiketi.Add(t);
            return t;
        }
        public static Tiket6 DajNarandzaste(int broj)
        {
            if (broj != 4 && broj != 11 && broj != 18 && broj != 25 && broj != 32 && broj != 39 && broj != 46)
                throw new Exception("Taj broj ne spada u narandzaste!");
            Tiket6 t = new Tiket6();
            t.Brojevi.Capacity = 7;
            t.Brojevi.Add(4);
            t.Brojevi.Add(11);
            t.Brojevi.Add(18);
            t.Brojevi.Add(25);
            t.Brojevi.Add(32);
            t.Brojevi.Add(39);
            t.Brojevi.Add(46);
            if (t.Brojevi.Contains(broj)) t.Brojevi.Remove(broj);
            t.Brojevi.Capacity = 6;
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            //Administrator.TrenutnaIgra.OdigraniTiketi.Add(t);
            return t;
        }
        public static Tiket6 DajZelene(int broj)
        {
            if (broj != 5 && broj != 12 && broj != 19 && broj != 26 && broj != 33 && broj != 40 && broj != 47)
                throw new Exception("Taj broj ne spada u zelene!");
            Tiket6 t = new Tiket6();
            t.Brojevi.Capacity = 7;
            t.Brojevi.Add(5);
            t.Brojevi.Add(12);
            t.Brojevi.Add(19);
            t.Brojevi.Add(26);
            t.Brojevi.Add(33);
            t.Brojevi.Add(40);
            t.Brojevi.Add(47);
            if (t.Brojevi.Contains(broj)) t.Brojevi.Remove(broj);
            t.Brojevi.Capacity = 6;
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            //Administrator.TrenutnaIgra.OdigraniTiketi.Add(t);
            return t;
        }
        public static Tiket6 DajRoze(int broj)
        {
            if (broj != 6 && broj != 13 && broj != 20 && broj != 27 && broj != 34 && broj != 41 && broj != 48)
                throw new Exception("Taj broj ne spada u roze!");
            Tiket6 t = new Tiket6();
            t.Brojevi.Capacity = 7;
            t.Brojevi.Add(6);
            t.Brojevi.Add(13);
            t.Brojevi.Add(20);
            t.Brojevi.Add(27);
            t.Brojevi.Add(34);
            t.Brojevi.Add(41);
            t.Brojevi.Add(48);
            if (t.Brojevi.Contains(broj)) t.Brojevi.Remove(broj);
            t.Brojevi.Capacity = 6;
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            //Administrator.TrenutnaIgra.OdigraniTiketi.Add(t);
            return t;
        }
        public static Tiket6 DajLjubicaste(int broj)
        {
            if (broj != 7 && broj != 14 && broj != 21 && broj != 28 && broj != 35 && broj != 42 && broj != 49)
                throw new Exception("Taj broj ne spada u ljubicaste!");
            Tiket6 t = new Tiket6();
            t.Brojevi.Capacity = 7;
            t.Brojevi.Add(7);
            t.Brojevi.Add(14);
            t.Brojevi.Add(21);
            t.Brojevi.Add(28);
            t.Brojevi.Add(35);
            t.Brojevi.Add(42);
            t.Brojevi.Add(49);
            if (t.Brojevi.Contains(broj)) t.Brojevi.Remove(broj);
            t.Brojevi.Capacity = 6;
            t.ProvjeriBrojeve();
            t.SortirajBrojeve();
            //Administrator.TrenutnaIgra.OdigraniTiketi.Add(t);
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

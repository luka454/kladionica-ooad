using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class Igra49 : Igra
    {
        public int ID { get; set; }
        public List<int> IzvuceniBrojevi { get; set; }
        public List<int> MoguciBrojevi { get; set; }
        public Tiket6 Tiket { get; set; }
        public int TrenutniBroj { get; set; }

        public Igra49()
        {
            IzvuceniBrojevi = new List<int>();
            IzvuceniBrojevi.Capacity = 35;
            MoguciBrojevi = new List<int>();
            MoguciBrojevi.Capacity = 49;
            Tiket = new Tiket6();
        }
        public int DajSljedeciBroj()
        {
            Random rand = new Random();
            for (int i = 1; i <= 49; i++)
                MoguciBrojevi.Add(i);
            int granica = 49;
            TrenutniBroj = rand.Next(0, granica--);
            MoguciBrojevi.RemoveAt(TrenutniBroj);
            IzvuceniBrojevi.Add(TrenutniBroj);
            return TrenutniBroj;
        }
        public void DodajObserver(Tiket6 t)
        {
            //OdigraniTiketi.Add(t);
        }
        public void IzbrisiObserver(Tiket6 t)
        {
            //OdigraniTiketi.Remove(t);
        }
        public void Obavijesti()
        {
            Tiket.Obavijesti(TrenutniBroj);
        }
    }
}

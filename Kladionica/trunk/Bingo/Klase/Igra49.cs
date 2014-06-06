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
        public List<Tiket6> OdigraniTiketi { get; set; }
        public int TrenutniBroj { get; set; }

        public Igra49()
        {
            IzvuceniBrojevi = new List<int>();
            IzvuceniBrojevi.Capacity = 35;
            MoguciBrojevi = new List<int>();
            MoguciBrojevi.Capacity = 49;
            OdigraniTiketi = new List<Tiket6>();
        }
        public int DajSljedeciBroj()
        {
            if (IzvuceniBrojevi.Count > 35) throw new Exception("Maksimalno 35 brojeva!");
            Random rand = new Random();
            for (int i = 1; i <= 49; i++)
                MoguciBrojevi.Add(i);
            int granica = 49;
            TrenutniBroj = rand.Next(0, granica--);
            MoguciBrojevi.RemoveAt(TrenutniBroj);
            IzvuceniBrojevi.Add(TrenutniBroj);
            return TrenutniBroj;
        }
        public void DodajObserver(Tiket6 t) {
            OdigraniTiketi.Add(t);
        }
        public void IzbrisiObserver(Tiket6 t) {
            OdigraniTiketi.Remove(t);
        }
        public void Obavijesti()
        {
            foreach (Tiket6 tiket in OdigraniTiketi) {
                tiket.Obavijesti(TrenutniBroj);
            }
        }
    }
}

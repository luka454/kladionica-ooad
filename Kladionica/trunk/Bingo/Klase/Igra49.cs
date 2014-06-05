using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class Igra49
    {
        public List<int> IzvuceniBrojevi { get; set; }
        public List<int> MoguciBrojevi { get; set; }

        public Igra49()
        {
            IzvuceniBrojevi = new List<int>();
            IzvuceniBrojevi.Capacity = 35;
            MoguciBrojevi = new List<int>();
            MoguciBrojevi.Capacity = 49;
        }
        public int DajSljedeciBroj()
        {
            Random rand = new Random();
            int tempBroj;
            for (int i = 1; i <= 49; i++)
                MoguciBrojevi.Add(i);
            int granica = 49;
            tempBroj = rand.Next(0, granica--);
            MoguciBrojevi.RemoveAt(tempBroj);
            IzvuceniBrojevi.Add(tempBroj);
            return tempBroj;
        }
    }
}

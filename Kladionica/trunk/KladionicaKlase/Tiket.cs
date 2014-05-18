using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaKlase
{
    public class Tiket
    {
        private List<StavkaTiketa> OdigraneIgre { get; set; }
        public decimal UkupniKoeficijent { get; set; }
        public decimal Ulog { get; set; }
        public TipTiketa TipTiketa { get; set; }
        public int ID { get; set; }

        public Tiket(int id, decimal uk, decimal ul, TipTiketa tt)
        {
            ID = id;
            UkupniKoeficijent = uk;
            Ulog = ul;
            TipTiketa = tt;
            OdigraneIgre = new List<StavkaTiketa>();
        }
        public bool JelDobitni() 
        {
            foreach(StavkaTiketa st in OdigraneIgre) if(st.JeLiDobitni() == false) return false;
            return true;
        }
        public List<StavkaTiketa> DajIgre() { return OdigraneIgre; }
        public List<StavkaTiketa> DajDobitneIgre() 
        {
            List<StavkaTiketa> dobitne = new List<StavkaTiketa>();
            foreach (StavkaTiketa st in OdigraneIgre) if (st.JeLiDobitni()) dobitne.Add(st);
            return dobitne;
        }
    }
}

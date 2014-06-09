using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public abstract class Igra
    {
        public int ID { get; set; }
        public DateTime Pocetak { get; set; }
        public String Naziv { get; set; }
        public StatusIgre statusIgre { get; set; }
        public List<Koeficijent> koeficijenti { get; set; }

        public Igra(DateTime p, string n, StatusIgre si)
        {
            Pocetak = p;
            Naziv = n;
            statusIgre = si;
            koeficijenti = new List<Koeficijent>();
        }
        public abstract Boolean ProvjeriTip(String tip);
        public abstract Boolean ProvjeriJeLiDobitni(String tip);

        public void dodajKoeficijent(Koeficijent k)
        {
            if (ProvjeriTip(k.tip) == false) throw new Exception("Neispravan tip");
            foreach (var item in koeficijenti)
            {
                if(item == k) return;
                if (item.tip == k.tip) throw new Exception("Postojeci tip vec postoji");
            }

            koeficijenti.Add(k);
        }
    }

}

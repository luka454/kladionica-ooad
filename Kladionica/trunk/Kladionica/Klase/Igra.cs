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
    }

}

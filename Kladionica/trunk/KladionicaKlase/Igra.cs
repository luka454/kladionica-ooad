using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaKlase
{
    public abstract class Igra
    {
        public int ID { get; set; }
        public DateTime Pocetak { get; set; }
        public String Naziv { get; set; }
        public StatusIgre satusIgre { get; set; }
        public List<Koeficijent> koeficijenti { get; set; }

        public abstract Boolean ProvjeriTip(String tip);
        public abstract Boolean ProvjeriJeLiDobitni(String tip);
    }

}

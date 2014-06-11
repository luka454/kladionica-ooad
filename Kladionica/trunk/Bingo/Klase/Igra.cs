using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public interface Igra
    {
        void DodajTiket(Tiket6 t);
        void IzbrisiTiket(Tiket6 t);
        void Obavijesti();
    }
}

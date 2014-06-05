using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public interface Igra
    {
        void DodajObserver(Tiket6 t);
        void IzbrisiObserver(Tiket6 t);
        void Obavijesti(int broj);
    }
}

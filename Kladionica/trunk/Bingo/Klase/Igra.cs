using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public interface Igra
    {
        public void DodajObserver(Tiket6 t);
        public void IzbrisiObserver(Tiket6 t);
        public void Obavijesti(int broj);
    }
}

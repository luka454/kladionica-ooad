using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public class Tiket
    {
        private int _ID;
        private tipTiketa _tipTiketa;
        private decimal _ulog;
        private decimal _ukupniKoeficijent;

        public decimal DajUkupniKoeficijent
        {
            get { return _ukupniKoeficijent; }
            set { _ukupniKoeficijent = value; }
        }        

        public decimal DajUlog
        {
            get { return _ulog; }
            set { _ulog = value; }
        }        

        public tipTiketa DajTipTiketa
        {
            get { return _tipTiketa; }
            set { _tipTiketa = value; }
        }        

        public int DajID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public Boolean JelDobitni() { return false; }
        public List<OdigraneIgre> DajIgre() { return _odigraneIgre }
        public List<OdigraneIgre> DajDobitneIgre() { return _dobitneIgre }
    }
}

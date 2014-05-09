using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public class FudbalskaUtakmica: TwoSideWLDMatch
    {
        public int BrojKorneraDomacin { get; set; }
        public int BrojKorneraGost { get; set; }
        public int BrojZutihDomacin { get; set; }
        public int BrojZutihGost { get; set; }



        public override bool ProvjeriTip(string tip)
        {
            string[] temp = new string[7]{"1", "1x", "x1", "x", "2x", "x2", "2"};
            foreach (var item in temp)
            {
                if (item.Equals(tip.ToLower()))
                    return true;
            }

            return false;
        }

        public override bool ProvjeriJeLiDobitni(string tip)
        {
            switch (tip.ToLower())
            {
                case "1":
                    return PoeniDomacin > PoeniGost;
                case "1x":
                case "x1":
                    return PoeniDomacin >= PoeniGost;
                case "x":
                    return PoeniDomacin == PoeniGost;
                case "2x":
                case "x2":
                    return PoeniDomacin <= PoeniGost;
                case "2":
                    return PoeniDomacin < PoeniGost;
                default:
                    throw new Exception("Nije dobar tip");
            }
        }
    }
}

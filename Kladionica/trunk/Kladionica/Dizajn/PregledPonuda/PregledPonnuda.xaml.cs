using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Kladionica.Dizajn.PregledPonuda;

namespace Kladionica
{
    /// <summary>
    /// Interaction logic for PregledPonnuda.xaml
    /// </summary>
    public partial class PregledPonuda : ContentControl
    {
        Ponuda _ponuda;
        public PregledPonuda(Ponuda ponudaZaPrikaz, string filter = "")
        {
            InitializeComponent();
            filter = filter.ToLower();

            _ponuda = ponudaZaPrikaz;
            foreach (var item in _ponuda.IgreUPonudi)
            {
               // MessageBox.Show(item.Naziv);
                if (item is FudbalskaUtakmica)
                {
                    
                    FudbalskaUtakmica u = (FudbalskaUtakmica)item;
                    string str = String.Format("{0} {3} {1} {2} ", item.ID, u.Domacin, u.Gost, u.Naziv).ToLower(); ;
                    if (str.Contains(filter))
                        fudbalkseUtakmice.Items.Add(new FUListBoxItem(u));
                    
                    
                }
                    
                else if (item is Tenis)
                {
                    Tenis t = (Tenis)item;
                    string str = String.Format("{0} {3} {1} {2} ", item.ID, t.PrviProtivnik, t.DrugiProtivnik, t.Naziv).ToLower();
                    if (str.Contains(filter))
                        Tenis.Items.Add(new TenisListBoxItem(t));
                }
            }

            
           
        }

    }
}

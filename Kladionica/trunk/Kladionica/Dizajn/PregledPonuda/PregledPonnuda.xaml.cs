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
        public PregledPonuda(Ponuda ponudaZaPrikaz)
        {
            InitializeComponent();

            _ponuda = ponudaZaPrikaz;
            foreach (var item in _ponuda.IgreUPonudi)
            {
               // MessageBox.Show(item.Naziv);
                if (item is FudbalskaUtakmica)
                {
                    fudbalkseUtakmice.Items.Add(new FUListBoxItem((FudbalskaUtakmica)item));
                }
                    
                else if (item is Tenis)
                {
                    
                    Tenis.Items.Add(new TenisListBoxItem((Tenis)item));
                }
            }

            
           
        }

    }
}

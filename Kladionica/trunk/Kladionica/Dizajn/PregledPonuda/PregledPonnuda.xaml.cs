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
            List<FudbalskaUtakmica> fu = new List<FudbalskaUtakmica>();
            foreach (var item in _ponuda.IgreUPonudi)
            {
                if (item is FudbalskaUtakmica)
                {
                    fudbalkseUtakmice.Items.Add(new FUNijePocelo((FudbalskaUtakmica)item));
                }
            }
            
           
        }

    }
}

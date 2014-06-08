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

namespace Kladionica.Dizajn.PregledPonuda
{
    /// <summary>
    /// Interaction logic for FUNijePocelo.xaml
    /// </summary>
    public partial class FUNijePocelo : ListBoxItem
    {

        String rec;
        List<Koeficijent> koeficijenti;

        public FUNijePocelo(FudbalskaUtakmica f)
        {
            
            InitializeComponent();
            if(f.Naziv != String.Empty) natpis.Text = f.Naziv + ": ";
            natpis.Text += String.Format("{0} - {1}", f.Domacin, f.Gost);

            vrijeme.Text = f.Pocetak.ToString("d.M.yyyy hh:mm");
        }
    }
}

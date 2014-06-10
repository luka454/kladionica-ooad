using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Kladionica.NoviTiket
{
    /// <summary>
    /// Interaction logic for UneseniTiketLBI.xaml
    /// </summary>
    public partial class UneseniTiketLBI : ListBoxItem
    {
        
        public StavkaTiketa _igra;
        public UneseniTiketLBI(StavkaTiketa igra)
        {
            _igra = igra;
            InitializeComponent();

            if (_igra.OdigranaIgra is FudbalskaUtakmica)
            {
                FudbalskaUtakmica f = (FudbalskaUtakmica)_igra.OdigranaIgra;
                natpis.Text = "";
                natpis.Text += f.ID + " - ";
                if (f.Naziv != String.Empty) natpis.Text += f.Naziv + ": ";
                natpis.Text += String.Format("{0} - {1}", f.Domacin, f.Gost);
            }
            else if (_igra.OdigranaIgra is Tenis)
            {
                Tenis t = (Tenis)_igra.OdigranaIgra;
                natpis.Text = "";
                natpis.Text += t.ID + " - ";
                if (t.Naziv != String.Empty) natpis.Text += t.Naziv + ": ";
                natpis.Text += String.Format("{0} - {1}", t.PrviProtivnik, t.DrugiProtivnik);
            }

            tip.Text = _igra.OdigraniTip;
            foreach (var item in _igra.OdigranaIgra.koeficijenti)
	        {
		        if(item.tip == _igra.OdigraniTip){
                    koef.Text = Math.Round(item.koeficijent,2).ToString(CultureInfo.InvariantCulture);
                    break;
                }
            }

            vrijeme.Text = _igra.OdigranaIgra.Pocetak.ToString("d.M.yyyy hh:mm");
            
        }
    }
}

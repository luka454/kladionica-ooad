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
    public partial class FUListBoxItem : ListBoxItem
    {

        public FUListBoxItem(FudbalskaUtakmica f)
        {
            
            InitializeComponent();

            natpis.Text = "";
            natpis.Text += f.ID + " - ";
            if(f.Naziv != String.Empty) natpis.Text += f.Naziv + ": ";
            natpis.Text += String.Format("{0} - {1}", f.Domacin, f.Gost);
            
            if (f.statusIgre == StatusIgre.UToku || f.statusIgre == StatusIgre.Zavrsena)
                natpis.Text += String.Format(" ({0} - {1})", f.PoeniDomacin, f.PoeniGost);
            
            vrijeme.Text = f.Pocetak.ToString("d.M.yyyy hh:mm");

            foreach (var item in f.koeficijenti)
            {
                //MessageBox.Show(String.Format("{2} : {0} - {1}", item.tip, item.koeficijent, f.ID));
                switch (item.tip.ToLower())
                {
                    case "1":
                        K1.Text = Math.Round(item.koeficijent,2).ToString();
                        break;
                    case "1x":
                    case "x1":
                        K1x.Text = Math.Round(item.koeficijent, 2).ToString();
                        break;
                    case "x":
                        Kx.Text = Math.Round(item.koeficijent, 2).ToString();
                        break;
                    case "2x":
                    case "x2":
                        Kx2.Text = Math.Round(item.koeficijent, 2).ToString();
                        break;
                    case "2":
                        K2.Text = Math.Round(item.koeficijent, 2).ToString();
                        break;
                }
            }

            switch (f.statusIgre)
            {
                case StatusIgre.NijePocela:
                    Status.Text = "Nije pocela";
                    break;
                case StatusIgre.Obustavljena:
                    Status.Text = "Obustavljena";
                    break;
                case StatusIgre.Odgodjena:
                    Status.Text = "Odgodjena";
                    break;
                case StatusIgre.UToku:
                    Status.Text = "U toku";
                    break;
                case StatusIgre.Zavrsena:
                    Status.Text = "Zavrsena";
                    break;
            }
        }
    }
}

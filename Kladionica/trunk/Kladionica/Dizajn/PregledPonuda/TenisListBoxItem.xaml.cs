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
    public partial class TenisListBoxItem : ListBoxItem
    {

        public TenisListBoxItem(Tenis t)
        {
            
            InitializeComponent();

            natpis.Text = "";
            natpis.Text += t.ID + " - ";
            if(t.Naziv != String.Empty) natpis.Text += t.Naziv + ": ";
            natpis.Text += String.Format("{0} - {1}", t.PrviProtivnik, t.DrugiProtivnik);
            
            if (t.statusIgre == StatusIgre.UToku || t.statusIgre == StatusIgre.Zavrsena)
                natpis.Text += String.Format(" ({0} - {1})", t.PrviPoenaSetova, t.DrugiPoenaSetova);
            
            vrijeme.Text = t.Pocetak.ToString("d.M.yyyy hh:mm");

            foreach (var item in t.koeficijenti)
            {
                //MessageBox.Show(String.Format("{2} : {0} - {1}", item.tip, item.koeficijent, f.ID));
                switch (item.tip.ToLower())
                {
                    case "1":
                        K1.Text = Math.Round(item.koeficijent,2).ToString();
                        break;
                    
                    case "2":
                        K2.Text = Math.Round(item.koeficijent, 2).ToString();
                        break;
                }
            }

            switch (t.statusIgre)
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

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

namespace Kladionica.NoviTiket
{
    /// <summary>
    /// Interaction logic for UnosNovogTiketa.xaml
    /// </summary>
    public partial class UnosNovogTiketa : ListBoxItem
    {
        ListBox _owner;
        Igra igra;
        public UnosNovogTiketa(ListBox owner)
        {
            _owner = owner;
            InitializeComponent();

            IMGerr.Visibility = System.Windows.Visibility.Hidden;
        }

        private void TBID_LostFocus(object sender, RoutedEventArgs e)
        {
            int ID;
            if (!Int32.TryParse(TBID.Text,out ID))
            {
                Natpis.Text = "Uneseni ID mora biti broj!";
                TBID.Focus();
                return;
            }

            igra = BazaPodataka.DAL.Factory.getIgraDao().getById(ID);
            if (igra == null)
            {
                Natpis.Text = "Igra s unesenim IDem nije pronadjena!";
                TBID.Focus();
                return;
            }

            if (igra.statusIgre != StatusIgre.NijePocela)
            {
                Natpis.Text = "Igra je ";
                switch (igra.statusIgre)
                {
                    case StatusIgre.Obustavljena:
                        Natpis.Text += "obustavljena!";
                        break;
                    case StatusIgre.Odgodjena:
                        Natpis.Text += "odgodjena!";
                        break;
                    case StatusIgre.UToku:
                        Natpis.Text += "u toku!";
                        break;
                    case StatusIgre.Zavrsena:
                        Natpis.Text += "zavresena!";
                        break;
                }

                TBID.Focus();
                return;
            }


            if (igra is FudbalskaUtakmica)
            {
                FudbalskaUtakmica f = (FudbalskaUtakmica)igra;
                Natpis.Text = "";
                Natpis.Text += f.ID + " - ";
                if (f.Naziv != String.Empty) Natpis.Text += f.Naziv + ": ";
                Natpis.Text += String.Format("{0} - {1}", f.Domacin, f.Gost);
            }
            else if (igra is Tenis)
            {
                Tenis t = (Tenis)igra;
                Natpis.Text = "";
                Natpis.Text += t.ID + " - ";
                if (t.Naziv != String.Empty) Natpis.Text += t.Naziv + ": ";
                Natpis.Text += String.Format("{0} - {1}", t.PrviProtivnik, t.DrugiProtivnik);
            }

            TBID.IsEnabled = false;
            TBTip.IsEnabled = true;
            TBTip.Focusable = true;
            TBTip.Focus();
            MessageBox.Show(TBTip.IsFocused.ToString());
            
            
        }

        private void TBTip_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!igra.ProvjeriTip(TBTip.Text))
            {
                IMGerr.Visibility = System.Windows.Visibility.Visible;
                TekstGreska.Text = "Uneseni tip nije ispravan.";
                return;
            }

            IMGerr.Visibility = System.Windows.Visibility.Hidden;

            TBTip.IsEnabled = false;
            BDodaj.IsEnabled = true;

            BDodaj.Focus();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _owner.Items.Remove(this);
            _owner.Items.Add(new UnosNovogTiketa(_owner));
               
        }
    }
}

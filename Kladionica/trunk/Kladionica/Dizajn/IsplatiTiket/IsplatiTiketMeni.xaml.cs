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

namespace Kladionica.Dizajn.IsplatiTiket
{
    /// <summary>
    /// Interaction logic for IsplatiTiketMeni.xaml
    /// </summary>
    public partial class IsplatiTiketMeni : ContentControl
    {
        ClanKluba _clan;
        Tiket t;
        public IsplatiTiketMeni(ClanKluba clan)
        {
            _clan = clan;
            InitializeComponent();

            listaTiketa.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int ID;
            if (!Int32.TryParse(TBID.Text, out ID))
            {
                MessageBox.Show("Morate unijeti integer");
                return;
            }

             t = BazaPodataka.DAL.Factory.getTiketDAO().getById(ID);

            if (t == null)
            {
                MessageBox.Show("Nije pronadjen tiket s danim IDom");
                return;
            }

            unosIDtiketa.Visibility = System.Windows.Visibility.Collapsed;
            listaTiketa.Visibility = System.Windows.Visibility.Visible;

            bool sveZavrsene = true;
            bool paoListic = false;
            Decimal dobitak = t.UkupniDobitak();
            foreach (var item in t.OdigraneIgre)
            {
                NoviTiket.UneseniTiketLBI i = new NoviTiket.UneseniTiketLBI(item);
                switch (item.OdigranaIgra.statusIgre)
                {
                    case StatusIgre.UToku:
                        i.Background = Brushes.Yellow;
                        sveZavrsene = false;
                        
                        break;
                    case StatusIgre.Zavrsena:
                        if (!item.JeLiDobitni())
                        {
                            paoListic = true;
                            i.Background = Brushes.Red;
                        }
                        else
                        {
                            i.Background = Brushes.ForestGreen;
                        }
                        break;
                    case StatusIgre.Odgodjena:
                    case StatusIgre.Obustavljena:
                        dobitak /= item.Koeficijent();
                        break;
                    default:
                        sveZavrsene = false;
                        break;
                }
            }

            if (paoListic)
            {
                MessageBox.Show("Zao nam je pali ste listic");
                koef.Text = "0.00";
                BIsplati.IsEnabled = false;
                return;
            }

            if (!sveZavrsene)
            {
                koef.Text = Math.Round(dobitak, 2).ToString();
                BIsplati.IsEnabled = false;
                return;
            }

            dobitak *= t.Ulog;

            koef.Text = Math.Round(dobitak, 2).ToString();
        }

        private void BIsplati_Click_1(object sender, RoutedEventArgs e)
        {
            decimal iznos = Decimal.Parse(koef.Text);
            BIsplati.IsEnabled = false;
            BazaPodataka.DAL.Factory.getTransakcijaDAO().create(new Transakcija(DateTime.Now, -iznos));
            BazaPodataka.DAL.Factory.getTiketDAO().updateUlog(t, 0M);
            if (_clan == null)
            {
                BIsplati.IsEnabled = false;
                MessageBox.Show("Čestitamo dobili ste: " + iznos + " KM!");
                return;
            }
            else
            {
                BIsplati.IsEnabled = false;
                _clan.Novac += iznos;
                MessageBox.Show("Čestitamo dobili ste: " + iznos + " KM!");
                return;
            }
        }
    }
}

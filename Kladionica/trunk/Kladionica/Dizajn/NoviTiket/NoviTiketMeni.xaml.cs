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
    /// Interaction logic for NoviTiketMeni.xaml
    /// </summary>
    public partial class NoviTiketMeni : ContentControl
    {
        ClanKluba _clan;
        List<StavkaTiketa> stavke;
        decimal ukupniKoeficijent;
        public NoviTiketMeni(ClanKluba clan = null)
        {
            _clan = clan;
            stavke = new List<StavkaTiketa>();
            ukupniKoeficijent = 1;

            InitializeComponent();

            if (_clan != null) ImeKorisnika.Text = _clan.Ime + " " + _clan.Prezime;
            listbox.Items.Add(new UnosNovogTiketa(listbox, this));

            uplataObicni.Visibility = System.Windows.Visibility.Collapsed;
        }

        public void dodajStavku(StavkaTiketa s){
            bool nadjen = false;
            foreach (var item in s.OdigranaIgra.koeficijenti)
            {
                if (s.OdigraniTip.ToLower().Equals(item.tip.ToLower()))
                {
                    ukupniKoeficijent *= item.koeficijent;
                    nadjen = true;
                    break;
                }
            }
            if(nadjen == false)
                throw new Exception("Nije pronadjen tip");

            koef.Text = Math.Round(ukupniKoeficijent, 2).ToString(CultureInfo.InvariantCulture);
            listbox.Items.Add(new UneseniTiketLBI(s));
            stavke.Add(s);
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (_clan == null)
            {
                borderKreiranje.IsEnabled = false;
                uplataObicni.Visibility = System.Windows.Visibility.Visible;
             
            }
            else
            {

            }

        }

        private void TBnovac_TextChanged(object sender, TextChangedEventArgs e)
        {
            Decimal dec;
            if(Decimal.TryParse(TBnovac.Text, out dec))
                Dobitak.Text = Math.Round(ukupniKoeficijent * dec, 2).ToString(CultureInfo.InvariantCulture);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (_clan == null)
            {
                Tiket tiket = new Tiket(ukupniKoeficijent, Convert.ToDecimal(TBnovac.Text), TipTiketa.Normalni);
                tiket.OdigraneIgre = stavke;
                BazaPodataka.DAL.Factory.getTiketDAO().create(tiket);
            }
        }
    }
}

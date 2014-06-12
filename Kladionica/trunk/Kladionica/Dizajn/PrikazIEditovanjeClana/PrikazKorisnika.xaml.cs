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

namespace Kladionica
{
    /// <summary>
    /// Interaction logic for PrikazKorisnika.xaml
    /// </summary>
    public partial class PrikazKorisnika : ContentControl
    {
        public PrikazKorisnika()
        {
            InitializeComponent();
        }
        ClanKluba _c;
        ContentPresenter _p;
        public PrikazKorisnika(ClanKluba c, ContentPresenter p)
        {
            InitializeComponent();
            Username.Content = c.Username;
            Prezime.Content = c.Prezime;
            Ime.Content = c.Ime;
            Novac.Content = c.Novac;
            _c = c;
            _p = p;
        }

        private void UplatiNovac_Click(object sender, RoutedEventArgs e)
        {
            UplataIIsplata u = new UplataIIsplata("Uplata", _c, _p);
            u.Show();
        }

        private void IsplatiNovac_Click(object sender, RoutedEventArgs e)
        {
            UplataIIsplata u = new UplataIIsplata("Isplata", _c, _p);
            u.Show();
        }

        private void PromijeniPass_Click(object sender, RoutedEventArgs e)
        {
            _p.Content = new PromijeniPIN(_c, _p);            
        }

        private void EditClan_Click(object sender, RoutedEventArgs e)
        {
            _p.Content = new EditKorisnika(_p, _c);
        }

        private void OdigrajTiket_Click_1(object sender, RoutedEventArgs e)
        {
            _p.Content = new NoviTiket.NoviTiketMeni(_c);
        }


    }
}

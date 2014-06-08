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

namespace Bingo
{
    /// <summary>
    /// Interaction logic for IzaberiBrojeve.xaml
    /// </summary>
    public partial class IzaberiBrojeve : Window
    {
        public List<Kuglice> _kuglice { get; set; }
        public IzaberiBrojeve()
        {
            InitializeComponent();
            _kuglice = new List<Kuglice>();
            foreach (var item in sveaaa.Children)
            {
                if (item is Kuglice)
                    _kuglice.Add((Kuglice)item);
            }
        }

        private void CrveneButton_Click(object sender, RoutedEventArgs e)
        {
            Kuglica1.Background = Brushes.Silver;
            Kuglica8.Background = Brushes.Silver;
            Kuglica15.Background = Brushes.Silver;
            Kuglica22.Background = Brushes.Silver;
            Kuglica29.Background = Brushes.Silver;
            Kuglica36.Background = Brushes.Silver;
            Kuglica43.Background = Brushes.Silver;
            if (Kuglica1.IsSelected) {
                TiketFactory.DajCrvene(1);
                Kuglica1.Background = Brushes.Red;
                return;
            }
            else if (Kuglica8.IsSelected) {
                TiketFactory.DajCrvene(8);
                Kuglica8.Background = Brushes.Red;
                return;
            }
            else if (Kuglica15.IsSelected) {
                TiketFactory.DajCrvene(15);
                Kuglica15.Background = Brushes.Red;
                return;
            }
            else if (Kuglica22.IsSelected) { 
                TiketFactory.DajCrvene(22);
                Kuglica22.Background = Brushes.Red;
                return;
            }
            else if (Kuglica29.IsSelected) {
                TiketFactory.DajCrvene(29);
                Kuglica29.Background = Brushes.Red;
                return;
            }
            else if (Kuglica36.IsSelected) { 
                TiketFactory.DajCrvene(36);
                Kuglica36.Background = Brushes.Red;
                return;
            }
            else if (Kuglica43.IsSelected) { 
                TiketFactory.DajCrvene(43);
                Kuglica43.Background = Brushes.Red;
                return;
            }
            else return;
        }

        private void ZuteButton_Click(object sender, RoutedEventArgs e)
        {
            Kuglica2.Background = Brushes.Silver;
            Kuglica9.Background = Brushes.Silver;
            Kuglica16.Background = Brushes.Silver;
            Kuglica23.Background = Brushes.Silver;
            Kuglica30.Background = Brushes.Silver;
            Kuglica37.Background = Brushes.Silver;
            Kuglica44.Background = Brushes.Silver;
            if (Kuglica2.IsSelected)
            {
                TiketFactory.DajZute(2);
                Kuglica2.Background = Brushes.Yellow;
                return;
            }
            else if (Kuglica9.IsSelected)
            {
                TiketFactory.DajZute(9);
                Kuglica9.Background = Brushes.Yellow;
                return;
            }
            else if (Kuglica16.IsSelected)
            {
                TiketFactory.DajZute(16);
                Kuglica16.Background = Brushes.Yellow;
                return;
            }
            else if (Kuglica23.IsSelected)
            {
                TiketFactory.DajZute(23);
                Kuglica23.Background = Brushes.Yellow;
                return;
            }
            else if (Kuglica30.IsSelected)
            {
                TiketFactory.DajZute(30);
                Kuglica30.Background = Brushes.Yellow;
                return;
            }
            else if (Kuglica37.IsSelected)
            {
                TiketFactory.DajZute(37);
                Kuglica37.Background = Brushes.Yellow;
                return;
            }
            else if (Kuglica44.IsSelected)
            {
                TiketFactory.DajZute(44);
                Kuglica44.Background = Brushes.Yellow;
                return;
            }
            else return;
        }

        private void PlaveButton_Click(object sender, RoutedEventArgs e)
        {
            Kuglica3.Background = Brushes.Silver;
            Kuglica10.Background = Brushes.Silver;
            Kuglica17.Background = Brushes.Silver;
            Kuglica24.Background = Brushes.Silver;
            Kuglica31.Background = Brushes.Silver;
            Kuglica38.Background = Brushes.Silver;
            Kuglica45.Background = Brushes.Silver;
            if (Kuglica3.IsSelected)
            {
                TiketFactory.DajPlave(3);
                Kuglica3.Background = Brushes.Blue;
                return;
            }
            else if (Kuglica10.IsSelected)
            {
                TiketFactory.DajPlave(10);
                Kuglica10.Background = Brushes.Blue;
                return;
            }
            else if (Kuglica17.IsSelected)
            {
                TiketFactory.DajPlave(17);
                Kuglica17.Background = Brushes.Blue;
                return;
            }
            else if (Kuglica24.IsSelected)
            {
                TiketFactory.DajPlave(24);
                Kuglica24.Background = Brushes.Blue;
                return;
            }
            else if (Kuglica31.IsSelected)
            {
                TiketFactory.DajPlave(31);
                Kuglica31.Background = Brushes.Blue;
                return;
            }
            else if (Kuglica38.IsSelected)
            {
                TiketFactory.DajPlave(38);
                Kuglica38.Background = Brushes.Blue;
                return;
            }
            else if (Kuglica45.IsSelected)
            {
                TiketFactory.DajPlave(45);
                Kuglica45.Background = Brushes.Blue;
                return;
            }
            else return;
        }

        private void NarandzasteButton_Click(object sender, RoutedEventArgs e)
        {
            Kuglica4.Background = Brushes.Silver;
            Kuglica11.Background = Brushes.Silver;
            Kuglica18.Background = Brushes.Silver;
            Kuglica25.Background = Brushes.Silver;
            Kuglica32.Background = Brushes.Silver;
            Kuglica39.Background = Brushes.Silver;
            Kuglica46.Background = Brushes.Silver;
            if (Kuglica4.IsSelected)
            {
                TiketFactory.DajNarandzaste(4);
                Kuglica4.Background = Brushes.Orange;
                return;
            }
            else if (Kuglica11.IsSelected)
            {
                TiketFactory.DajNarandzaste(11);
                Kuglica11.Background = Brushes.Orange;
                return;
            }
            else if (Kuglica18.IsSelected)
            {
                TiketFactory.DajNarandzaste(18);
                Kuglica18.Background = Brushes.Orange;
                return;
            }
            else if (Kuglica25.IsSelected)
            {
                TiketFactory.DajNarandzaste(25);
                Kuglica25.Background = Brushes.Orange;
                return;
            }
            else if (Kuglica32.IsSelected)
            {
                TiketFactory.DajNarandzaste(32);
                Kuglica32.Background = Brushes.Orange;
                return;
            }
            else if (Kuglica39.IsSelected)
            {
                TiketFactory.DajNarandzaste(39);
                Kuglica39.Background = Brushes.Orange;
                return;
            }
            else if (Kuglica46.IsSelected)
            {
                TiketFactory.DajNarandzaste(46);
                Kuglica46.Background = Brushes.Orange;
                return;
            }
            else return;
        }

        private void ZeleneButton_Click(object sender, RoutedEventArgs e)
        {
            Kuglica5.Background = Brushes.Silver;
            Kuglica12.Background = Brushes.Silver;
            Kuglica19.Background = Brushes.Silver;
            Kuglica26.Background = Brushes.Silver;
            Kuglica33.Background = Brushes.Silver;
            Kuglica40.Background = Brushes.Silver;
            Kuglica47.Background = Brushes.Silver;
            if (Kuglica5.IsSelected)
            {
                TiketFactory.DajZelene(5);
                Kuglica5.Background = Brushes.LimeGreen;
                return;
            }
            else if (Kuglica5.IsSelected)
            {
                TiketFactory.DajZelene(5);
                Kuglica5.Background = Brushes.LimeGreen;
                return;
            }
            else if (Kuglica5.IsSelected)
            {
                TiketFactory.DajZelene(5);
                Kuglica5.Background = Brushes.LimeGreen;
                return;
            }
            else if (Kuglica5.IsSelected)
            {
                TiketFactory.DajZelene(5);
                Kuglica5.Background = Brushes.LimeGreen;
                return;
            }
            else if (Kuglica5.IsSelected)
            {
                TiketFactory.DajZelene(5);
                Kuglica5.Background = Brushes.LimeGreen;
                return;
            }
            else if (Kuglica5.IsSelected)
            {
                TiketFactory.DajZelene(5);
                Kuglica5.Background = Brushes.LimeGreen;
                return;
            }
            else if (Kuglica5.IsSelected)
            {
                TiketFactory.DajZelene(5);
                Kuglica5.Background = Brushes.LimeGreen;
                return;
            }
            else return;
        }

        private void RozeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LjubicasteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Kuglica1_Click(object sender, RoutedEventArgs e)
        {
            Kuglica1.IsSelected = true;
            Kuglica1.Background = Brushes.Silver;
            for (int i = 1; i < 49; i++) {
                _kuglice[i].IsSelected = false;
            }
        }
    }
}

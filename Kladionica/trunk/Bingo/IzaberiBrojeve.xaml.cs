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
            this.Title = "Bingo";
            _kuglice = new List<Kuglice>();
            foreach (var item in sveaaa.Children)
            {
                if (item is Kuglice)
                    _kuglice.Add((Kuglice)item);
            }
        }

        private void CrveneButton_Click(object sender, RoutedEventArgs e)
        {
            Kuglica1.Foreground = Brushes.Silver;
            Kuglica8.Foreground = Brushes.Silver;
            Kuglica15.Foreground = Brushes.Silver;
            Kuglica22.Foreground = Brushes.Silver;
            Kuglica29.Foreground = Brushes.Silver;
            Kuglica36.Foreground = Brushes.Silver;
            Kuglica43.Foreground = Brushes.Silver;
            /*if (Kuglica1.IsSelected) {                
                TiketFactory.DajCrvene(1);
                Kuglica1.Foreground = Brushes.Black;
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
            else return;*/
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
            Kuglica6.Background = Brushes.Silver;
            Kuglica13.Background = Brushes.Silver;
            Kuglica20.Background = Brushes.Silver;
            Kuglica27.Background = Brushes.Silver;
            Kuglica34.Background = Brushes.Silver;
            Kuglica41.Background = Brushes.Silver;
            Kuglica48.Background = Brushes.Silver;
            if (Kuglica6.IsSelected)
            {
                TiketFactory.DajRoze(6);
                Kuglica6.Background = Brushes.HotPink;
                return;
            }
            else if (Kuglica13.IsSelected)
            {
                TiketFactory.DajRoze(13);
                Kuglica13.Background = Brushes.HotPink;
                return;
            }
            else if (Kuglica20.IsSelected)
            {
                TiketFactory.DajRoze(20);
                Kuglica20.Background = Brushes.HotPink;
                return;
            }
            else if (Kuglica27.IsSelected)
            {
                TiketFactory.DajRoze(27);
                Kuglica27.Background = Brushes.HotPink;
                return;
            }
            else if (Kuglica34.IsSelected)
            {
                TiketFactory.DajRoze(34);
                Kuglica34.Background = Brushes.HotPink;
                return;
            }
            else if (Kuglica41.IsSelected)
            {
                TiketFactory.DajRoze(41);
                Kuglica41.Background = Brushes.HotPink;
                return;
            }
            else if (Kuglica48.IsSelected)
            {
                TiketFactory.DajRoze(48);
                Kuglica48.Background = Brushes.HotPink;
                return;
            }
            else return;
        }

        private void LjubicasteButton_Click(object sender, RoutedEventArgs e)
        {
            Kuglica7.Background = Brushes.Silver;
            Kuglica14.Background = Brushes.Silver;
            Kuglica21.Background = Brushes.Silver;
            Kuglica28.Background = Brushes.Silver;
            Kuglica35.Background = Brushes.Silver;
            Kuglica42.Background = Brushes.Silver;
            Kuglica49.Background = Brushes.Silver;
            if (Kuglica7.IsSelected)
            {
                TiketFactory.DajLjubicaste(7);
                Kuglica7.Background = Brushes.Indigo;
                return;
            }
            else if (Kuglica14.IsSelected)
            {
                TiketFactory.DajLjubicaste(14);
                Kuglica14.Background = Brushes.Indigo;
                return;
            }
            else if (Kuglica21.IsSelected)
            {
                TiketFactory.DajLjubicaste(21);
                Kuglica21.Background = Brushes.Indigo;
                return;
            }
            else if (Kuglica28.IsSelected)
            {
                TiketFactory.DajLjubicaste(28);
                Kuglica28.Background = Brushes.Indigo;
                return;
            }
            else if (Kuglica35.IsSelected)
            {
                TiketFactory.DajLjubicaste(35);
                Kuglica35.Background = Brushes.Indigo;
                return;
            }
            else if (Kuglica42.IsSelected)
            {
                TiketFactory.DajLjubicaste(42);
                Kuglica42.Background = Brushes.Indigo;
                return;
            }
            else if (Kuglica49.IsSelected)
            {
                TiketFactory.DajLjubicaste(49);
                Kuglica49.Background = Brushes.Indigo;
                return;
            }
            else return;
        }

        private void Kuglica1_Click(object sender, RoutedEventArgs e)
        {
            Kuglica1.IsSelected = true;
            Kuglica1.Foreground = Brushes.Black;
            TiketFactory.DajCrvene(1);            
        }

        private void Kuglica2_Click(object sender, RoutedEventArgs e)
        {
            Kuglica2.IsSelected = true;
            Kuglica2.Background = Brushes.Silver;
        }

        private void Kuglica3_Click(object sender, RoutedEventArgs e)
        {
            Kuglica3.IsSelected = true;
            Kuglica3.Background = Brushes.Silver;
        }

        private void Kuglica4_Click(object sender, RoutedEventArgs e)
        {
            Kuglica4.IsSelected = true;
            Kuglica4.Background = Brushes.Silver;
        }

        private void Kuglica5_Click(object sender, RoutedEventArgs e)
        {
            Kuglica5.IsSelected = true;
            Kuglica5.Background = Brushes.Silver;
        }

        private void Kuglica6_Click(object sender, RoutedEventArgs e)
        {
            Kuglica6.IsSelected = true;
            Kuglica6.Background = Brushes.Silver;
        }

        private void Kuglica7_Click(object sender, RoutedEventArgs e)
        {
            Kuglica7.IsSelected = true;
            Kuglica7.Background = Brushes.Silver;
        }

        private void Kuglica8_Click(object sender, RoutedEventArgs e)
        {
            Kuglica8.IsSelected = true;
            Kuglica8.Background = Brushes.Silver;
        }

        private void Kuglica9_Click(object sender, RoutedEventArgs e)
        {
            Kuglica9.IsSelected = true;
            Kuglica9.Background = Brushes.Silver;
        }

        private void Kuglica10_Click(object sender, RoutedEventArgs e)
        {
            Kuglica10.IsSelected = true;
            Kuglica10.Background = Brushes.Silver;
        }

        private void Kuglica11_Click(object sender, RoutedEventArgs e)
        {
            Kuglica11.IsSelected = true;
            Kuglica11.Background = Brushes.Silver;
        }

        private void Kuglica12_Click(object sender, RoutedEventArgs e)
        {
            Kuglica12.IsSelected = true;
            Kuglica12.Background = Brushes.Silver;
        }

        private void Kuglica13_Click(object sender, RoutedEventArgs e)
        {
            Kuglica13.IsSelected = true;
            Kuglica13.Background = Brushes.Silver;
        }

        private void Kuglica14_Click(object sender, RoutedEventArgs e)
        {
            Kuglica14.IsSelected = true;
            Kuglica14.Background = Brushes.Silver;
        }

        private void Kuglica15_Click(object sender, RoutedEventArgs e)
        {
            Kuglica15.IsSelected = true;
            Kuglica15.Background = Brushes.Silver;
        }

        private void Kuglica16_Click(object sender, RoutedEventArgs e)
        {
            Kuglica16.IsSelected = true;
            Kuglica16.Background = Brushes.Silver;
        }

        private void Kuglica17_Click(object sender, RoutedEventArgs e)
        {
            Kuglica17.IsSelected = true;
            Kuglica17.Background = Brushes.Silver;
        }

        private void Kuglica18_Click(object sender, RoutedEventArgs e)
        {
            Kuglica18.IsSelected = true;
            Kuglica18.Background = Brushes.Silver;
        }

        private void Kuglica19_Click(object sender, RoutedEventArgs e)
        {
            Kuglica19.IsSelected = true;
            Kuglica19.Background = Brushes.Silver;
        }

        private void Kuglica20_Click(object sender, RoutedEventArgs e)
        {
            Kuglica20.IsSelected = true;
            Kuglica20.Background = Brushes.Silver;
        }

        private void Kuglica21_Click(object sender, RoutedEventArgs e)
        {
            Kuglica21.IsSelected = true;
            Kuglica21.Background = Brushes.Silver;
        }

        private void Kuglica22_Click(object sender, RoutedEventArgs e)
        {
            Kuglica22.IsSelected = true;
            Kuglica22.Background = Brushes.Silver;
        }

        private void Kuglica23_Click(object sender, RoutedEventArgs e)
        {
            Kuglica23.IsSelected = true;
            Kuglica23.Background = Brushes.Silver;
        }

        private void Kuglica24_Click(object sender, RoutedEventArgs e)
        {
            Kuglica24.IsSelected = true;
            Kuglica24.Background = Brushes.Silver;
        }

        private void Kuglica25_Click(object sender, RoutedEventArgs e)
        {
            Kuglica25.IsSelected = true;
            Kuglica25.Background = Brushes.Silver;
        }

        private void Kuglica26_Click(object sender, RoutedEventArgs e)
        {
            Kuglica26.IsSelected = true;
            Kuglica26.Background = Brushes.Silver;
        }

        private void Kuglica27_Click(object sender, RoutedEventArgs e)
        {
            Kuglica27.IsSelected = true;
            Kuglica27.Background = Brushes.Silver;
        }

        private void Kuglica28_Click(object sender, RoutedEventArgs e)
        {
            Kuglica28.IsSelected = true;
            Kuglica28.Background = Brushes.Silver;
        }

        private void Kuglica29_Click(object sender, RoutedEventArgs e)
        {
            Kuglica29.IsSelected = true;
            Kuglica29.Foreground = Brushes.Black;
            TiketFactory.DajCrvene(29);  
        }

        private void Kuglica30_Click(object sender, RoutedEventArgs e)
        {
            Kuglica30.IsSelected = true;
            Kuglica30.Background = Brushes.Silver;
        }

        private void Kuglica31_Click(object sender, RoutedEventArgs e)
        {
            Kuglica31.IsSelected = true;
            Kuglica31.Background = Brushes.Silver;
        }

        private void Kuglica32_Click(object sender, RoutedEventArgs e)
        {
            Kuglica32.IsSelected = true;
            Kuglica32.Background = Brushes.Silver;
        }

        private void Kuglica33_Click(object sender, RoutedEventArgs e)
        {
            Kuglica33.IsSelected = true;
            Kuglica33.Background = Brushes.Silver;
        }

        private void Kuglica34_Click(object sender, RoutedEventArgs e)
        {
            Kuglica34.IsSelected = true;
            Kuglica34.Background = Brushes.Silver;
        }

        private void Kuglica35_Click(object sender, RoutedEventArgs e)
        {
            Kuglica35.IsSelected = true;
            Kuglica35.Background = Brushes.Silver;
        }

        private void Kuglica36_Click(object sender, RoutedEventArgs e)
        {
            Kuglica36.IsSelected = true;
            Kuglica36.Background = Brushes.Silver;
        }

        private void Kuglica37_Click(object sender, RoutedEventArgs e)
        {
            Kuglica37.IsSelected = true;
            Kuglica37.Background = Brushes.Silver;
        }

        private void Kuglica38_Click(object sender, RoutedEventArgs e)
        {
            Kuglica38.IsSelected = true;
            Kuglica38.Background = Brushes.Silver;
        }

        private void Kuglica39_Click(object sender, RoutedEventArgs e)
        {
            Kuglica39.IsSelected = true;
            Kuglica39.Background = Brushes.Silver;
        }

        private void Kuglica40_Click(object sender, RoutedEventArgs e)
        {
            Kuglica40.IsSelected = true;
            Kuglica40.Background = Brushes.Silver;
        }

        private void Kuglica41_Click(object sender, RoutedEventArgs e)
        {
            Kuglica41.IsSelected = true;
            Kuglica41.Background = Brushes.Silver;
        }

        private void Kuglica42_Click(object sender, RoutedEventArgs e)
        {
            Kuglica42.IsSelected = true;
            Kuglica42.Background = Brushes.Silver;
        }

        private void Kuglica43_Click(object sender, RoutedEventArgs e)
        {
            Kuglica43.IsSelected = true;
            Kuglica43.Background = Brushes.Silver;
        }

        private void Kuglica44_Click(object sender, RoutedEventArgs e)
        {
            Kuglica44.IsSelected = true;
            Kuglica44.Background = Brushes.Silver;
        }

        private void Kuglica45_Click(object sender, RoutedEventArgs e)
        {
            Kuglica45.IsSelected = true;
            Kuglica45.Background = Brushes.Silver;
        }

        private void Kuglica46_Click(object sender, RoutedEventArgs e)
        {
            Kuglica46.IsSelected = true;
            Kuglica46.Background = Brushes.Silver;
        }

        private void Kuglica47_Click(object sender, RoutedEventArgs e)
        {
            Kuglica47.IsSelected = true;
            Kuglica47.Background = Brushes.Silver;
        }

        private void Kuglica48_Click(object sender, RoutedEventArgs e)
        {
            Kuglica48.IsSelected = true;
            Kuglica48.Background = Brushes.Silver;
        }

        private void Kuglica49_Click(object sender, RoutedEventArgs e)
        {
            Kuglica49.IsSelected = true;
            Kuglica49.Background = Brushes.Silver;
        }

    }
}

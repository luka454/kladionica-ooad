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
        public Tiket6 _tiket { get; set; }
        public bool AktivirajCrvene { get; set; }
        public bool AktivirajZute { get; set; }
        public bool AktivirajPlave { get; set; }
        public bool AktivirajNarandzaste { get; set; }
        public bool AktivirajZelene { get; set; }
        public bool AktivirajRoze { get; set; }
        public bool AktivirajLjubicaste { get; set; }
        public IzaberiBrojeve()
        {
            InitializeComponent();
            this.Title = "Bingo";
            _kuglice = new List<Kuglice>();
            _tiket = new Tiket6();
            AktivirajCrvene = false;
            AktivirajLjubicaste=false;
            AktivirajNarandzaste=false;
            AktivirajPlave=false;
            AktivirajRoze=false;
            AktivirajZelene=false;
            AktivirajZute=false;
            foreach (var item in sveaaa.Children)
            {
                if (item is Kuglice)
                    _kuglice.Add((Kuglice)item);
            }
        }

        private void CrveneButton_Click(object sender, RoutedEventArgs e)
        {
            AktivirajCrvene = true;
            Kuglica1.Background = Brushes.Gray;
            Kuglica8.Background = Brushes.Gray;
            Kuglica15.Background = Brushes.Gray;
            Kuglica22.Background = Brushes.Gray;
            Kuglica29.Background = Brushes.Gray;
            Kuglica36.Background = Brushes.Gray;
            Kuglica43.Background = Brushes.Gray;
        }

        private void ZuteButton_Click(object sender, RoutedEventArgs e)
        {
            AktivirajZute=true;
            Kuglica2.Background = Brushes.Gray;
            Kuglica9.Background = Brushes.Gray;
            Kuglica16.Background = Brushes.Gray;
            Kuglica23.Background = Brushes.Gray;
            Kuglica30.Background = Brushes.Gray;
            Kuglica37.Background = Brushes.Gray;
            Kuglica44.Background = Brushes.Gray;
        }

        private void PlaveButton_Click(object sender, RoutedEventArgs e)
        {
            AktivirajPlave=true;
            Kuglica3.Background = Brushes.Gray;
            Kuglica10.Background = Brushes.Gray;
            Kuglica17.Background = Brushes.Gray;
            Kuglica24.Background = Brushes.Gray;
            Kuglica31.Background = Brushes.Gray;
            Kuglica38.Background = Brushes.Gray;
            Kuglica45.Background = Brushes.Gray;
        }

        private void NarandzasteButton_Click(object sender, RoutedEventArgs e)
        {
            AktivirajNarandzaste=true;
            Kuglica4.Background = Brushes.Gray;
            Kuglica11.Background = Brushes.Gray;
            Kuglica18.Background = Brushes.Gray;
            Kuglica25.Background = Brushes.Gray;
            Kuglica32.Background = Brushes.Gray;
            Kuglica39.Background = Brushes.Gray;
            Kuglica46.Background = Brushes.Gray;
        }

        private void ZeleneButton_Click(object sender, RoutedEventArgs e)
        {
            AktivirajZelene=true;
            Kuglica5.Background = Brushes.Gray;
            Kuglica12.Background = Brushes.Gray;
            Kuglica19.Background = Brushes.Gray;
            Kuglica26.Background = Brushes.Gray;
            Kuglica33.Background = Brushes.Gray;
            Kuglica40.Background = Brushes.Gray;
            Kuglica47.Background = Brushes.Gray;
        }

        private void RozeButton_Click(object sender, RoutedEventArgs e)
        {
            AktivirajRoze=true;
            Kuglica6.Background = Brushes.Gray;
            Kuglica13.Background = Brushes.Gray;
            Kuglica20.Background = Brushes.Gray;
            Kuglica27.Background = Brushes.Gray;
            Kuglica34.Background = Brushes.Gray;
            Kuglica41.Background = Brushes.Gray;
            Kuglica48.Background = Brushes.Gray;
        }

        private void LjubicasteButton_Click(object sender, RoutedEventArgs e)
        {
            AktivirajLjubicaste=true;
            Kuglica7.Background = Brushes.Gray;
            Kuglica14.Background = Brushes.Gray;
            Kuglica21.Background = Brushes.Gray;
            Kuglica28.Background = Brushes.Gray;
            Kuglica35.Background = Brushes.Gray;
            Kuglica42.Background = Brushes.Gray;
            Kuglica49.Background = Brushes.Gray;
        }

        private void Kuglica1_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajCrvene)
            {
                Kuglica1.IsSelected = false;
                Kuglica1.Background = Brushes.Red;
                _tiket=TiketFactory.DajCrvene(1);
                return;
            }
            Kuglica1.IsSelected = true;
            Kuglica1.Background = Brushes.Gray;          
        }

        private void Kuglica2_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajZute)
            {
                Kuglica2.IsSelected = false;
                Kuglica2.Background = Brushes.Yellow;
                _tiket = TiketFactory.DajCrvene(2);
                return;
            }
            Kuglica2.IsSelected = true;
            Kuglica2.Background = Brushes.Gray;   
        }

        private void Kuglica3_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajPlave)
            {
                Kuglica3.IsSelected = false;
                Kuglica3.Background = Brushes.Blue;
                _tiket = TiketFactory.DajCrvene(3);
                return;
            }
            Kuglica3.IsSelected = true;
            Kuglica3.Background = Brushes.Gray;   
        }

        private void Kuglica4_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajNarandzaste)
            {
                Kuglica4.IsSelected = false;
                Kuglica4.Background = Brushes.Orange;
                _tiket = TiketFactory.DajCrvene(4);
                return;
            }
            Kuglica4.IsSelected = true;
            Kuglica4.Background = Brushes.Gray;   
        }

        private void Kuglica5_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajZelene)
            {
                Kuglica5.IsSelected = false;
                Kuglica5.Background = Brushes.LimeGreen;
                _tiket = TiketFactory.DajCrvene(5);
                return;
            }
            Kuglica5.IsSelected = true;
            Kuglica5.Background = Brushes.Gray;   
        }

        private void Kuglica6_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajRoze)
            {
                Kuglica6.IsSelected = false;
                Kuglica6.Background = Brushes.HotPink;
                _tiket = TiketFactory.DajCrvene(6);
                return;
            }
            Kuglica6.IsSelected = true;
            Kuglica6.Background = Brushes.Gray;   
        }

        private void Kuglica7_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste)
            {
                Kuglica7.IsSelected = false;
                Kuglica7.Background = Brushes.Indigo;
                _tiket = TiketFactory.DajCrvene(7);
                return;
            }
            Kuglica7.IsSelected = true;
            Kuglica7.Background = Brushes.Gray;   
        }

        private void Kuglica8_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajCrvene)
            {
                Kuglica8.IsSelected = false;
                Kuglica8.Background = Brushes.Red;
                _tiket = TiketFactory.DajCrvene(8);
                return;
            }
            Kuglica8.IsSelected = true;
            Kuglica8.Background = Brushes.Gray;         
        }

        private void Kuglica9_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajZute)
            {
                Kuglica9.IsSelected = false;
                Kuglica9.Background = Brushes.Yellow;
                _tiket = TiketFactory.DajCrvene(9);
                return;
            }
            Kuglica9.IsSelected = true;
            Kuglica9.Background = Brushes.Gray;   
        }

        private void Kuglica10_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajPlave)
            {
                Kuglica10.IsSelected = false;
                Kuglica10.Background = Brushes.Blue;
                _tiket = TiketFactory.DajCrvene(10);
                return;
            }
            Kuglica10.IsSelected = true;
            Kuglica10.Background = Brushes.Gray;   
        }

        private void Kuglica11_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajNarandzaste)
            {
                Kuglica11.IsSelected = false;
                Kuglica11.Background = Brushes.Orange;
                _tiket = TiketFactory.DajCrvene(11);
                return;
            }
            Kuglica11.IsSelected = true;
            Kuglica11.Background = Brushes.Gray;   
        }

        private void Kuglica12_Click(object sender, RoutedEventArgs e)
        {
            Kuglica12.IsSelected = true;
            Kuglica12.Background = Brushes.Gray;
        }

        private void Kuglica13_Click(object sender, RoutedEventArgs e)
        {
            Kuglica13.IsSelected = true;
            Kuglica13.Background = Brushes.Gray;
        }

        private void Kuglica14_Click(object sender, RoutedEventArgs e)
        {
            Kuglica14.IsSelected = true;
            Kuglica14.Background = Brushes.Gray;
        }

        private void Kuglica15_Click(object sender, RoutedEventArgs e)
        {
            if (CrveneButton.IsEnabled)
            {
                Kuglica15.IsSelected = false;
                Kuglica15.Background = Brushes.Red;
                _tiket = TiketFactory.DajCrvene(15);
                return;
            }
            Kuglica15.IsSelected = true;
            Kuglica15.Background = Brushes.Gray;
        }

        private void Kuglica16_Click(object sender, RoutedEventArgs e)
        {
            Kuglica16.IsSelected = true;
            Kuglica16.Background = Brushes.Gray;
        }

        private void Kuglica17_Click(object sender, RoutedEventArgs e)
        {
            Kuglica17.IsSelected = true;
            Kuglica17.Background = Brushes.Gray;
        }

        private void Kuglica18_Click(object sender, RoutedEventArgs e)
        {
            Kuglica18.IsSelected = true;
            Kuglica18.Background = Brushes.Gray;
        }

        private void Kuglica19_Click(object sender, RoutedEventArgs e)
        {
            Kuglica19.IsSelected = true;
            Kuglica19.Background = Brushes.Gray;
        }

        private void Kuglica20_Click(object sender, RoutedEventArgs e)
        {
            Kuglica20.IsSelected = true;
            Kuglica20.Background = Brushes.Gray;
        }

        private void Kuglica21_Click(object sender, RoutedEventArgs e)
        {
            Kuglica21.IsSelected = true;
            Kuglica21.Background = Brushes.Gray;
        }

        private void Kuglica22_Click(object sender, RoutedEventArgs e)
        {
            if (CrveneButton.IsEnabled)
            {
                Kuglica22.IsSelected = false;
                Kuglica22.Background = Brushes.Red;
                _tiket = TiketFactory.DajCrvene(22);
                return;
            }
            Kuglica22.IsSelected = true;
            Kuglica22.Background = Brushes.Gray;
        }

        private void Kuglica23_Click(object sender, RoutedEventArgs e)
        {
            Kuglica23.IsSelected = true;
            Kuglica23.Background = Brushes.Gray;
        }

        private void Kuglica24_Click(object sender, RoutedEventArgs e)
        {
            Kuglica24.IsSelected = true;
            Kuglica24.Background = Brushes.Gray;
        }

        private void Kuglica25_Click(object sender, RoutedEventArgs e)
        {
            Kuglica25.IsSelected = true;
            Kuglica25.Background = Brushes.Gray;
        }

        private void Kuglica26_Click(object sender, RoutedEventArgs e)
        {
            Kuglica26.IsSelected = true;
            Kuglica26.Background = Brushes.Gray;
        }

        private void Kuglica27_Click(object sender, RoutedEventArgs e)
        {
            Kuglica27.IsSelected = true;
            Kuglica27.Background = Brushes.Gray;
        }

        private void Kuglica28_Click(object sender, RoutedEventArgs e)
        {
            Kuglica28.IsSelected = true;
            Kuglica28.Background = Brushes.Gray;
        }

        private void Kuglica29_Click(object sender, RoutedEventArgs e)
        {
            if (CrveneButton.IsEnabled)
            {
                Kuglica29.IsSelected = false;
                Kuglica29.Background = Brushes.Red;
                _tiket = TiketFactory.DajCrvene(29);
                return;
            }
            Kuglica29.IsSelected = true;
            Kuglica29.Background = Brushes.Gray;  
        }

        private void Kuglica30_Click(object sender, RoutedEventArgs e)
        {
            Kuglica30.IsSelected = true;
            Kuglica30.Background = Brushes.Gray;
        }

        private void Kuglica31_Click(object sender, RoutedEventArgs e)
        {
            Kuglica31.IsSelected = true;
            Kuglica31.Background = Brushes.Gray;
        }

        private void Kuglica32_Click(object sender, RoutedEventArgs e)
        {
            Kuglica32.IsSelected = true;
            Kuglica32.Background = Brushes.Gray;
        }

        private void Kuglica33_Click(object sender, RoutedEventArgs e)
        {
            Kuglica33.IsSelected = true;
            Kuglica33.Background = Brushes.Gray;
        }

        private void Kuglica34_Click(object sender, RoutedEventArgs e)
        {
            Kuglica34.IsSelected = true;
            Kuglica34.Background = Brushes.Gray;
        }

        private void Kuglica35_Click(object sender, RoutedEventArgs e)
        {
            Kuglica35.IsSelected = true;
            Kuglica35.Background = Brushes.Gray;
        }

        private void Kuglica36_Click(object sender, RoutedEventArgs e)
        {
            if (CrveneButton.IsEnabled)
            {
                Kuglica36.IsSelected = false;
                Kuglica36.Background = Brushes.Red;
                _tiket = TiketFactory.DajCrvene(36);
                return;
            }
            Kuglica36.IsSelected = true;
            Kuglica36.Background = Brushes.Gray;
        }

        private void Kuglica37_Click(object sender, RoutedEventArgs e)
        {
            Kuglica37.IsSelected = true;
            Kuglica37.Background = Brushes.Gray;
        }

        private void Kuglica38_Click(object sender, RoutedEventArgs e)
        {
            Kuglica38.IsSelected = true;
            Kuglica38.Background = Brushes.Gray;
        }

        private void Kuglica39_Click(object sender, RoutedEventArgs e)
        {
            Kuglica39.IsSelected = true;
            Kuglica39.Background = Brushes.Gray;
        }

        private void Kuglica40_Click(object sender, RoutedEventArgs e)
        {
            Kuglica40.IsSelected = true;
            Kuglica40.Background = Brushes.Gray;
        }

        private void Kuglica41_Click(object sender, RoutedEventArgs e)
        {
            Kuglica41.IsSelected = true;
            Kuglica41.Background = Brushes.Gray;
        }

        private void Kuglica42_Click(object sender, RoutedEventArgs e)
        {
            Kuglica42.IsSelected = true;
            Kuglica42.Background = Brushes.Gray;
        }

        private void Kuglica43_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajCrvene)
            {
                Kuglica43.IsSelected = false;
                Kuglica43.Background = Brushes.Red;
                _tiket = TiketFactory.DajCrvene(43);
                string ispis = Convert.ToString(_tiket.Brojevi[0]) + " " + Convert.ToString(_tiket.Brojevi[1]) + " " + Convert.ToString(_tiket.Brojevi[2]) +
                " " + Convert.ToString(_tiket.Brojevi[3]) + " " + Convert.ToString(_tiket.Brojevi[4]) + " " + Convert.ToString(_tiket.Brojevi[5]) +
                " " + Convert.ToString(_tiket.Brojevi.Count);
                MessageBox.Show(ispis);
                return;
            }
            Kuglica43.IsSelected = true;
            Kuglica43.Background = Brushes.Gray;
            
        }

        private void Kuglica44_Click(object sender, RoutedEventArgs e)
        {
            Kuglica44.IsSelected = true;
            Kuglica44.Background = Brushes.Gray;
        }

        private void Kuglica45_Click(object sender, RoutedEventArgs e)
        {
            Kuglica45.IsSelected = true;
            Kuglica45.Background = Brushes.Gray;
        }

        private void Kuglica46_Click(object sender, RoutedEventArgs e)
        {
            Kuglica46.IsSelected = true;
            Kuglica46.Background = Brushes.Gray;
        }

        private void Kuglica47_Click(object sender, RoutedEventArgs e)
        {
            Kuglica47.IsSelected = true;
            Kuglica47.Background = Brushes.Gray;
        }

        private void Kuglica48_Click(object sender, RoutedEventArgs e)
        {
            Kuglica48.IsSelected = true;
            Kuglica48.Background = Brushes.Gray;
        }

        private void Kuglica49_Click(object sender, RoutedEventArgs e)
        {
            Kuglica49.IsSelected = true;
            Kuglica49.Background = Brushes.Gray;
        }

        private void Automatski_Click(object sender, RoutedEventArgs e)
        {
            _tiket=TiketFactory.DajAutomatski();
            //_tiket.Brojevi.Add(1);
            //_tiket.Brojevi.Add(17);
            //_tiket.Brojevi.Add(22);
            //_tiket.Brojevi.Add(29);
            //_tiket.Brojevi.Add(43);
            //_tiket.Brojevi.Add(49);
            foreach (int broj in _tiket.Brojevi)
            {
                for (int i = 1; i <= 49; i++)
                {
                    if (broj == i)
                    {
                        int index = i - 1;
                        _kuglice[index].IsSelected = true;
                        _kuglice[index].Background = Brushes.Gray;                        
                    }
                }
            }
            MessageBox.Show("radi");
        }

    }
}

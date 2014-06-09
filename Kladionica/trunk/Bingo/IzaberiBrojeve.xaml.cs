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
            _tiket.Brojevi.Capacity = 6;
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
            foreach (Kuglice k in _kuglice)
                if (Grid.GetColumn(k) == 0)
                {
                    k.Background = Brushes.Gray;
                    k.IsSelected = true;
                }
        }

        private void ZuteButton_Click(object sender, RoutedEventArgs e)
        {
            AktivirajZute=true;
            foreach (Kuglice k in _kuglice)
                if (Grid.GetColumn(k) == 1)
                {
                    k.Background = Brushes.Gray;
                    k.IsSelected = true;
                }
        }

        private void PlaveButton_Click(object sender, RoutedEventArgs e)
        {
            AktivirajPlave=true;
            foreach (Kuglice k in _kuglice)
                if (Grid.GetColumn(k) == 2)
                {
                    k.Background = Brushes.Gray;
                    k.IsSelected = true;
                }
        }

        private void NarandzasteButton_Click(object sender, RoutedEventArgs e)
        {
            AktivirajNarandzaste=true;
            foreach (Kuglice k in _kuglice)
                if (Grid.GetColumn(k) == 3)
                {
                    k.Background = Brushes.Gray;
                    k.IsSelected = true;
                }
        }

        private void ZeleneButton_Click(object sender, RoutedEventArgs e)
        {
            AktivirajZelene=true;
            foreach (Kuglice k in _kuglice)
                if (Grid.GetColumn(k) == 4)
                {
                    k.Background = Brushes.Gray;
                    k.IsSelected = true;
                }
        }

        private void RozeButton_Click(object sender, RoutedEventArgs e)
        {
            AktivirajRoze=true;
            foreach (Kuglice k in _kuglice)
                if (Grid.GetColumn(k) == 5)
                {
                    k.Background = Brushes.Gray;
                    k.IsSelected = true;
                }
        }

        private void LjubicasteButton_Click(object sender, RoutedEventArgs e)
        {
            AktivirajLjubicaste=true;
            foreach (Kuglice k in _kuglice)
                if (Grid.GetColumn(k) == 6)
                {
                    k.Background = Brushes.Gray;
                    k.IsSelected = true;
                }
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
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica1.IsSelected = true;
            Kuglica1.Background = Brushes.Gray;
            _tiket.Brojevi.Add(1);
        }

        private void Kuglica2_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajZute)
            {
                Kuglica2.IsSelected = false;
                Kuglica2.Background = Brushes.Yellow;
                _tiket = TiketFactory.DajZute(2);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica2.IsSelected = true;
            Kuglica2.Background = Brushes.Gray;
            _tiket.Brojevi.Add(2);
        }

        private void Kuglica3_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajPlave)
            {
                Kuglica3.IsSelected = false;
                Kuglica3.Background = Brushes.Blue;
                _tiket = TiketFactory.DajPlave(3);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica3.IsSelected = true;
            Kuglica3.Background = Brushes.Gray;
            _tiket.Brojevi.Add(3);
        }

        private void Kuglica4_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajNarandzaste)
            {
                Kuglica4.IsSelected = false;
                Kuglica4.Background = Brushes.Orange;
                _tiket = TiketFactory.DajNarandzaste(4);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica4.IsSelected = true;
            Kuglica4.Background = Brushes.Gray;
            _tiket.Brojevi.Add(4);
        }

        private void Kuglica5_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajZelene)
            {
                Kuglica5.IsSelected = false;
                Kuglica5.Background = Brushes.LimeGreen;
                _tiket = TiketFactory.DajZelene(5);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica5.IsSelected = true;
            Kuglica5.Background = Brushes.Gray;
            _tiket.Brojevi.Add(5);
        }

        private void Kuglica6_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajRoze)
            {
                Kuglica6.IsSelected = false;
                Kuglica6.Background = Brushes.HotPink;
                _tiket = TiketFactory.DajRoze(6);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica6.IsSelected = true;
            Kuglica6.Background = Brushes.Gray;
            _tiket.Brojevi.Add(6);
        }

        private void Kuglica7_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste)
            {
                Kuglica7.IsSelected = false;
                Kuglica7.Background = Brushes.Indigo;
                _tiket = TiketFactory.DajLjubicaste(7);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica7.IsSelected = true;
            Kuglica7.Background = Brushes.Gray;
            _tiket.Brojevi.Add(7);
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
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica8.IsSelected = true;
            Kuglica8.Background = Brushes.Gray;
            _tiket.Brojevi.Add(8);
        }

        private void Kuglica9_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajZute)
            {
                Kuglica9.IsSelected = false;
                Kuglica9.Background = Brushes.Yellow;
                _tiket = TiketFactory.DajZute(9);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica9.IsSelected = true;
            Kuglica9.Background = Brushes.Gray;
            _tiket.Brojevi.Add(9);
        }

        private void Kuglica10_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajPlave)
            {
                Kuglica10.IsSelected = false;
                Kuglica10.Background = Brushes.Blue;
                _tiket = TiketFactory.DajPlave(10);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica10.IsSelected = true;
            Kuglica10.Background = Brushes.Gray;
            _tiket.Brojevi.Add(10);
        }

        private void Kuglica11_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajNarandzaste)
            {
                Kuglica11.IsSelected = false;
                Kuglica11.Background = Brushes.Orange;
                _tiket = TiketFactory.DajNarandzaste(11);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica11.IsSelected = true;
            Kuglica11.Background = Brushes.Gray;
            _tiket.Brojevi.Add(11);
        }

        private void Kuglica12_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajZelene)
            {
                Kuglica12.IsSelected = false;
                Kuglica12.Background = Brushes.LimeGreen;
                _tiket = TiketFactory.DajZelene(12);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica12.IsSelected = true;
            Kuglica12.Background = Brushes.Gray;
            _tiket.Brojevi.Add(12);
        }

        private void Kuglica13_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajRoze)
            {
                Kuglica13.IsSelected = false;
                Kuglica13.Background = Brushes.HotPink;
                _tiket = TiketFactory.DajRoze(13);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica13.IsSelected = true;
            Kuglica13.Background = Brushes.Gray;
            _tiket.Brojevi.Add(13);
        }

        private void Kuglica14_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste)
            {
                Kuglica14.IsSelected = false;
                Kuglica14.Background = Brushes.Indigo;
                _tiket = TiketFactory.DajLjubicaste(14);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica14.IsSelected = true;
            Kuglica14.Background = Brushes.Gray;
            _tiket.Brojevi.Add(14);
        }

        private void Kuglica15_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajCrvene)
            {
                Kuglica15.IsSelected = false;
                Kuglica15.Background = Brushes.Red;
                _tiket = TiketFactory.DajCrvene(15);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica15.IsSelected = true;
            Kuglica15.Background = Brushes.Gray;
            _tiket.Brojevi.Add(15);
        }

        private void Kuglica16_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajZute)
            {
                Kuglica16.IsSelected = false;
                Kuglica16.Background = Brushes.Yellow;
                _tiket = TiketFactory.DajZute(16);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica16.IsSelected = true;
            Kuglica16.Background = Brushes.Gray;
            _tiket.Brojevi.Add(16);
        }

        private void Kuglica17_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajPlave)
            {
                Kuglica17.IsSelected = false;
                Kuglica17.Background = Brushes.Blue;
                _tiket = TiketFactory.DajPlave(17);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica17.IsSelected = true;
            Kuglica17.Background = Brushes.Gray;
            _tiket.Brojevi.Add(17);
        }

        private void Kuglica18_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajNarandzaste)
            {
                Kuglica18.IsSelected = false;
                Kuglica18.Background = Brushes.Orange;
                _tiket = TiketFactory.DajNarandzaste(18);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica18.IsSelected = true;
            Kuglica18.Background = Brushes.Gray;
            _tiket.Brojevi.Add(18);
        }

        private void Kuglica19_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajZelene)
            {
                Kuglica19.IsSelected = false;
                Kuglica19.Background = Brushes.LimeGreen;
                _tiket = TiketFactory.DajZelene(19);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica19.IsSelected = true;
            Kuglica19.Background = Brushes.Gray;
            _tiket.Brojevi.Add(19);
        }

        private void Kuglica20_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajRoze)
            {
                Kuglica20.IsSelected = false;
                Kuglica20.Background = Brushes.HotPink;
                _tiket = TiketFactory.DajRoze(20);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica20.IsSelected = true;
            Kuglica20.Background = Brushes.Gray;
            _tiket.Brojevi.Add(20);
        }

        private void Kuglica21_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste)
            {
                Kuglica21.IsSelected = false;
                Kuglica21.Background = Brushes.Indigo;
                _tiket = TiketFactory.DajLjubicaste(21);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica21.IsSelected = true;
            Kuglica21.Background = Brushes.Gray;
            _tiket.Brojevi.Add(21);
        }

        private void Kuglica22_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajCrvene)
            {
                Kuglica22.IsSelected = false;
                Kuglica22.Background = Brushes.Red;
                _tiket = TiketFactory.DajCrvene(22);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica22.IsSelected = true;
            Kuglica22.Background = Brushes.Gray;
            _tiket.Brojevi.Add(22);
        }

        private void Kuglica23_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajZute)
            {
                Kuglica23.IsSelected = false;
                Kuglica23.Background = Brushes.Yellow;
                _tiket = TiketFactory.DajZute(23);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica23.IsSelected = true;
            Kuglica23.Background = Brushes.Gray;
            _tiket.Brojevi.Add(23);
        }

        private void Kuglica24_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajPlave)
            {
                Kuglica24.IsSelected = false;
                Kuglica24.Background = Brushes.Blue;
                _tiket = TiketFactory.DajPlave(24);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica24.IsSelected = true;
            Kuglica24.Background = Brushes.Gray;
            _tiket.Brojevi.Add(24);
        }

        private void Kuglica25_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajNarandzaste)
            {
                Kuglica25.IsSelected = false;
                Kuglica25.Background = Brushes.Orange;
                _tiket = TiketFactory.DajNarandzaste(25);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica25.IsSelected = true;
            Kuglica25.Background = Brushes.Gray;
            _tiket.Brojevi.Add(25);
        }

        private void Kuglica26_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajZelene)
            {
                Kuglica26.IsSelected = false;
                Kuglica26.Background = Brushes.LimeGreen;
                _tiket = TiketFactory.DajZelene(26);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica26.IsSelected = true;
            Kuglica26.Background = Brushes.Gray;
            _tiket.Brojevi.Add(26);
        }

        private void Kuglica27_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajRoze)
            {
                Kuglica27.IsSelected = false;
                Kuglica27.Background = Brushes.HotPink;
                _tiket = TiketFactory.DajRoze(27);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica27.IsSelected = true;
            Kuglica27.Background = Brushes.Gray;
            _tiket.Brojevi.Add(27);
        }

        private void Kuglica28_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste)
            {
                Kuglica28.IsSelected = false;
                Kuglica28.Background = Brushes.Indigo;
                _tiket = TiketFactory.DajLjubicaste(28);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica28.IsSelected = true;
            Kuglica28.Background = Brushes.Gray;
            _tiket.Brojevi.Add(28);
        }

        private void Kuglica29_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajCrvene)
            {
                Kuglica29.IsSelected = false;
                Kuglica29.Background = Brushes.Red;
                _tiket = TiketFactory.DajCrvene(29);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica29.IsSelected = true;
            Kuglica29.Background = Brushes.Gray;
            _tiket.Brojevi.Add(29);
        }

        private void Kuglica30_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajZute)
            {
                Kuglica30.IsSelected = false;
                Kuglica30.Background = Brushes.Yellow;
                _tiket = TiketFactory.DajZute(30);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica30.IsSelected = true;
            Kuglica30.Background = Brushes.Gray;
            _tiket.Brojevi.Add(30);
        }

        private void Kuglica31_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajPlave)
            {
                Kuglica31.IsSelected = false;
                Kuglica31.Background = Brushes.Blue;
                _tiket = TiketFactory.DajPlave(31);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica31.IsSelected = true;
            Kuglica31.Background = Brushes.Gray;
            _tiket.Brojevi.Add(31);
        }

        private void Kuglica32_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajNarandzaste)
            {
                Kuglica32.IsSelected = false;
                Kuglica32.Background = Brushes.Orange;
                _tiket = TiketFactory.DajNarandzaste(32);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica32.IsSelected = true;
            Kuglica32.Background = Brushes.Gray;
            _tiket.Brojevi.Add(32);
        }

        private void Kuglica33_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajZelene)
            {
                Kuglica33.IsSelected = false;
                Kuglica33.Background = Brushes.LimeGreen;
                _tiket = TiketFactory.DajZelene(33);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica33.IsSelected = true;
            Kuglica33.Background = Brushes.Gray;
            _tiket.Brojevi.Add(33);
        }

        private void Kuglica34_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajRoze)
            {
                Kuglica34.IsSelected = false;
                Kuglica34.Background = Brushes.HotPink;
                _tiket = TiketFactory.DajRoze(34);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica34.IsSelected = true;
            Kuglica34.Background = Brushes.Gray;
            _tiket.Brojevi.Add(34);
        }

        private void Kuglica35_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste)
            {
                Kuglica35.IsSelected = false;
                Kuglica35.Background = Brushes.Indigo;
                _tiket = TiketFactory.DajLjubicaste(35);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica35.IsSelected = true;
            Kuglica35.Background = Brushes.Gray;
            _tiket.Brojevi.Add(35);
        }

        private void Kuglica36_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajCrvene)
            {
                Kuglica36.IsSelected = false;
                Kuglica36.Background = Brushes.Red;
                _tiket = TiketFactory.DajCrvene(36);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica36.IsSelected = true;
            Kuglica36.Background = Brushes.Gray;
            _tiket.Brojevi.Add(36);
        }

        private void Kuglica37_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajZute)
            {
                Kuglica37.IsSelected = false;
                Kuglica37.Background = Brushes.Yellow;
                _tiket = TiketFactory.DajZute(37);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica37.IsSelected = true;
            Kuglica37.Background = Brushes.Gray;
            _tiket.Brojevi.Add(37);
        }

        private void Kuglica38_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajPlave)
            {
                Kuglica38.IsSelected = false;
                Kuglica38.Background = Brushes.Blue;
                _tiket = TiketFactory.DajPlave(38);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica38.IsSelected = true;
            Kuglica38.Background = Brushes.Gray;
            _tiket.Brojevi.Add(38);
        }

        private void Kuglica39_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajNarandzaste)
            {
                Kuglica39.IsSelected = false;
                Kuglica39.Background = Brushes.Orange;
                _tiket = TiketFactory.DajNarandzaste(39);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica39.IsSelected = true;
            Kuglica39.Background = Brushes.Gray;
            _tiket.Brojevi.Add(39);
        }

        private void Kuglica40_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajZelene)
            {
                Kuglica40.IsSelected = false;
                Kuglica40.Background = Brushes.LimeGreen;
                _tiket = TiketFactory.DajZelene(40);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica40.IsSelected = true;
            Kuglica40.Background = Brushes.Gray;
            _tiket.Brojevi.Add(40);
        }

        private void Kuglica41_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajRoze)
            {
                Kuglica41.IsSelected = false;
                Kuglica41.Background = Brushes.HotPink;
                _tiket = TiketFactory.DajRoze(41);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica41.IsSelected = true;
            Kuglica41.Background = Brushes.Gray;
            _tiket.Brojevi.Add(41);
        }

        private void Kuglica42_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste)
            {
                Kuglica42.IsSelected = false;
                Kuglica42.Background = Brushes.Indigo;
                _tiket = TiketFactory.DajLjubicaste(42);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica42.IsSelected = true;
            Kuglica42.Background = Brushes.Gray;
            _tiket.Brojevi.Add(42);
        }

        private void Kuglica43_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajCrvene)
            {
                Kuglica43.IsSelected = false;
                Kuglica43.Background = Brushes.Red;
                _tiket = TiketFactory.DajCrvene(43);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica43.IsSelected = true;
            Kuglica43.Background = Brushes.Gray;
            _tiket.Brojevi.Add(43);
        }

        private void Kuglica44_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajZute)
            {
                Kuglica44.IsSelected = false;
                Kuglica44.Background = Brushes.Yellow;
                _tiket = TiketFactory.DajZute(44);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica44.IsSelected = true;
            Kuglica44.Background = Brushes.Gray;
            _tiket.Brojevi.Add(44);
        }

        private void Kuglica45_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajPlave)
            {
                Kuglica45.IsSelected = false;
                Kuglica45.Background = Brushes.Blue;
                _tiket = TiketFactory.DajPlave(45);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica45.IsSelected = true;
            Kuglica45.Background = Brushes.Gray;
            _tiket.Brojevi.Add(45);
        }

        private void Kuglica46_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajNarandzaste)
            {
                Kuglica46.IsSelected = false;
                Kuglica46.Background = Brushes.Orange;
                _tiket = TiketFactory.DajNarandzaste(46);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica46.IsSelected = true;
            Kuglica46.Background = Brushes.Gray;
            _tiket.Brojevi.Add(46);
        }

        private void Kuglica47_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajZelene)
            {
                Kuglica47.IsSelected = false;
                Kuglica47.Background = Brushes.LimeGreen;
                _tiket = TiketFactory.DajZelene(47);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica47.IsSelected = true;
            Kuglica47.Background = Brushes.Gray;
            _tiket.Brojevi.Add(47);
        }

        private void Kuglica48_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajRoze)
            {
                Kuglica48.IsSelected = false;
                Kuglica48.Background = Brushes.HotPink;
                _tiket = TiketFactory.DajRoze(48);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica48.IsSelected = true;
            Kuglica48.Background = Brushes.Gray;
            _tiket.Brojevi.Add(48);
        }

        private void Kuglica49_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste)
            {
                Kuglica49.IsSelected = false;
                Kuglica49.Background = Brushes.Indigo;
                _tiket = TiketFactory.DajLjubicaste(49);
                return;
            }
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica49.IsSelected = true;
            Kuglica49.Background = Brushes.Gray;
            _tiket.Brojevi.Add(49);        
        }

        private void Automatski_Click(object sender, RoutedEventArgs e)
        {
            _tiket=TiketFactory.DajAutomatski();
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
            string ispis = Convert.ToString(_tiket.Brojevi[0]) + " " + Convert.ToString(_tiket.Brojevi[1]) + " " + Convert.ToString(_tiket.Brojevi[2]) +
               " " + Convert.ToString(_tiket.Brojevi[3]) + " " + Convert.ToString(_tiket.Brojevi[4]) + " " + Convert.ToString(_tiket.Brojevi[5]) +
               " " + Convert.ToString(_tiket.Brojevi.Count);
            MessageBox.Show(ispis);
        }

        private void Obicni_Click(object sender, RoutedEventArgs e)
        {
            _tiket = TiketFactory.DajNormalni(_tiket);
            string ispis = Convert.ToString(_tiket.Brojevi[0]) + " " + Convert.ToString(_tiket.Brojevi[1]) + " " + Convert.ToString(_tiket.Brojevi[2]) +
               " " + Convert.ToString(_tiket.Brojevi[3]) + " " + Convert.ToString(_tiket.Brojevi[4]) + " " + Convert.ToString(_tiket.Brojevi[5]) +
               " " + Convert.ToString(_tiket.Brojevi.Count);
            MessageBox.Show(ispis);
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            _tiket.ObrisiBrojeve();
            foreach (Kuglice k in _kuglice)
            {
                k.IsSelected = false;
                if (Grid.GetColumn(k) == 0) k.Background = Brushes.Red;
                else if (Grid.GetColumn(k) == 1) k.Background = Brushes.Yellow;
                else if (Grid.GetColumn(k) == 2) k.Background = Brushes.Blue;
                else if (Grid.GetColumn(k) == 3) k.Background = Brushes.Orange;
                else if (Grid.GetColumn(k) == 4) k.Background = Brushes.LimeGreen;
                else if (Grid.GetColumn(k) == 5) k.Background = Brushes.HotPink;
                else if (Grid.GetColumn(k) == 6) k.Background = Brushes.Indigo;
                else return;
            }
        }

    }
}

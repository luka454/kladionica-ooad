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
        public List<Kuglice> _mojeKuglice { get; set; }
        public Tiket6 _tiket { get; set; }
        public bool AktivirajCrvene { get; set; }
        public bool AktivirajZute { get; set; }
        public bool AktivirajPlave { get; set; }
        public bool AktivirajNarandzaste { get; set; }
        public bool AktivirajZelene { get; set; }
        public bool AktivirajRoze { get; set; }
        public bool AktivirajLjubicaste { get; set; }
        public bool JelAutomatski { get; set; }

        public IzaberiBrojeve()
        {
            InitializeComponent();
            this.Title = "Bingo";
            _kuglice = new List<Kuglice>();
            _mojeKuglice = new List<Kuglice>();
            _mojeKuglice.Capacity = 6;
            _tiket = new Tiket6();
            _tiket.Brojevi.Capacity = 6;
            AktivirajCrvene = false;
            AktivirajLjubicaste=false;
            AktivirajNarandzaste=false;
            AktivirajPlave=false;
            AktivirajRoze=false;
            AktivirajZelene=false;
            AktivirajZute=false;
            JelAutomatski = false;
            foreach (var item in sveaaa.Children)
            {
                if (item is Kuglice)
                    _kuglice.Add((Kuglice)item);
            }
            for (int i = 0; i < 49; i += 7)
                _kuglice[i].Broj = i + 1;
            for (int i = 1; i < 49; i += 7)
                _kuglice[i].Broj = i + 1;
            for (int i = 2; i < 49; i += 7)
                _kuglice[i].Broj = i + 1;
            for (int i = 3; i < 49; i += 7)
                _kuglice[i].Broj = i + 1;
            for (int i = 4; i < 49; i += 7)
                _kuglice[i].Broj = i + 1;
            for (int i = 5; i < 49; i += 7)
                _kuglice[i].Broj = i + 1;
            for (int i = 6; i < 49; i += 7)
                _kuglice[i].Broj = i + 1;
        }

        private void CrveneButton_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave || AktivirajRoze
                || AktivirajZelene || AktivirajZute || JelAutomatski) return;
            _tiket.ObrisiBrojeve();
            while (_mojeKuglice.Count != 0) _mojeKuglice.RemoveAt(0);
            AktivirajCrvene = true;
            _mojeKuglice.Capacity = 7;
            foreach (Kuglice k in _kuglice)
                if (Grid.GetColumn(k) == 0)
                {
                    k.Background = Brushes.Gray;
                    k.IsSelected = true;
                    k.Boja = "Crvene";
                    _mojeKuglice.Add(k);
                }
        }

        private void ZuteButton_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave || AktivirajRoze
                || AktivirajZelene || AktivirajCrvene || JelAutomatski) return;
            _tiket.ObrisiBrojeve();
            while (_mojeKuglice.Count != 0) _mojeKuglice.RemoveAt(0);
            AktivirajZute=true;
            _mojeKuglice.Capacity = 7;
            foreach (Kuglice k in _kuglice)
                if (Grid.GetColumn(k) == 1)
                {
                    k.Background = Brushes.Gray;
                    k.IsSelected = true;
                    k.Boja = "Zute";
                    _mojeKuglice.Add(k);
                }
        }

        private void PlaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajCrvene || AktivirajRoze
                || AktivirajZelene || AktivirajZute || JelAutomatski) return;
            _tiket.ObrisiBrojeve();
            while (_mojeKuglice.Count != 0) _mojeKuglice.RemoveAt(0);
            AktivirajPlave=true;
            _mojeKuglice.Capacity = 7;
            foreach (Kuglice k in _kuglice)
                if (Grid.GetColumn(k) == 2)
                {
                    k.Background = Brushes.Gray;
                    k.IsSelected = true;
                    k.Boja = "Plave";
                    _mojeKuglice.Add(k);
                }
        }

        private void NarandzasteButton_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajCrvene || AktivirajPlave || AktivirajRoze
                || AktivirajZelene || AktivirajZute || JelAutomatski) return;
            _tiket.ObrisiBrojeve();
            while (_mojeKuglice.Count != 0) _mojeKuglice.RemoveAt(0);
            AktivirajNarandzaste=true;
            _mojeKuglice.Capacity = 7;
            foreach (Kuglice k in _kuglice)
                if (Grid.GetColumn(k) == 3)
                {
                    k.Background = Brushes.Gray;
                    k.IsSelected = true;
                    k.Boja = "Narandzaste";
                    _mojeKuglice.Add(k);
                }
        }

        private void ZeleneButton_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave || AktivirajRoze
                || AktivirajCrvene || AktivirajZute || JelAutomatski) return;
            _tiket.ObrisiBrojeve();
            while (_mojeKuglice.Count != 0) _mojeKuglice.RemoveAt(0);
            AktivirajZelene=true;
            _mojeKuglice.Capacity = 7;
            foreach (Kuglice k in _kuglice)
                if (Grid.GetColumn(k) == 4)
                {
                    k.Background = Brushes.Gray;
                    k.IsSelected = true;
                    k.Boja = "Zelene";
                    _mojeKuglice.Add(k);
                }
        }

        private void RozeButton_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave || AktivirajCrvene
                || AktivirajZelene || AktivirajZute || JelAutomatski) return;
            _tiket.ObrisiBrojeve();
            while (_mojeKuglice.Count != 0) _mojeKuglice.RemoveAt(0);
            AktivirajRoze=true;
            _mojeKuglice.Capacity = 7;
            foreach (Kuglice k in _kuglice)
                if (Grid.GetColumn(k) == 5)
                {
                    k.Background = Brushes.Gray;
                    k.IsSelected = true;
                    k.Boja = "Roze";
                    _mojeKuglice.Add(k);
                }
        }

        private void LjubicasteButton_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajCrvene || AktivirajNarandzaste || AktivirajPlave || AktivirajRoze
                || AktivirajZelene || AktivirajZute || JelAutomatski) return;
            _tiket.ObrisiBrojeve();
            while (_mojeKuglice.Count != 0) _mojeKuglice.RemoveAt(0);
            AktivirajLjubicaste=true;
            _mojeKuglice.Capacity = 7;
            foreach (Kuglice k in _kuglice)
                if (Grid.GetColumn(k) == 6)
                {
                    k.Background = Brushes.Gray;
                    k.IsSelected = true;
                    k.Boja = "Ljubicaste";
                    _mojeKuglice.Add(k);
                }
        }

        private void Kuglica1_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajCrvene)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 0 && k != Kuglica1)
                        if (k.IsSelected == false) return;
                Kuglica1.IsSelected = false;
                Kuglica1.Background = Brushes.Red;
                _tiket=TiketFactory.DajCrvene(1);
                _mojeKuglice.Remove(Kuglica1);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica1.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica1.IsSelected = true;
            Kuglica1.Background = Brushes.Gray;
            _tiket.Brojevi.Add(1);
            _mojeKuglice.Add(Kuglica1);
        }

        private void Kuglica2_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajCrvene) return;
            if (AktivirajZute)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 1 && k != Kuglica2)
                        if (k.IsSelected == false) return;
                Kuglica2.IsSelected = false;
                Kuglica2.Background = Brushes.Yellow;
                _tiket = TiketFactory.DajZute(2);
                _mojeKuglice.Remove(Kuglica2);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica2.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica2.IsSelected = true;
            Kuglica2.Background = Brushes.Gray;
            _tiket.Brojevi.Add(2);
            _mojeKuglice.Add(Kuglica2);
        }

        private void Kuglica3_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajCrvene ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajPlave)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 2 && k != Kuglica3)
                        if (k.IsSelected == false) return;
                Kuglica3.IsSelected = false;
                Kuglica3.Background = Brushes.Blue;
                _tiket = TiketFactory.DajPlave(3);
                _mojeKuglice.Remove(Kuglica3);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica3.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica3.IsSelected = true;
            Kuglica3.Background = Brushes.Gray;
            _tiket.Brojevi.Add(3);
            _mojeKuglice.Add(Kuglica3);
        }

        private void Kuglica4_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajCrvene || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajNarandzaste)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 3 && k != Kuglica4)
                        if (k.IsSelected == false) return;
                Kuglica4.IsSelected = false;
                Kuglica4.Background = Brushes.Orange;
                _tiket = TiketFactory.DajNarandzaste(4);
                _mojeKuglice.Remove(Kuglica4);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica4.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica4.IsSelected = true;
            Kuglica4.Background = Brushes.Gray;
            _tiket.Brojevi.Add(4);
            _mojeKuglice.Add(Kuglica4);
        }

        private void Kuglica5_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajCrvene || AktivirajZute) return;
            if (AktivirajZelene)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 4 && k != Kuglica5)
                        if (k.IsSelected == false) return;
                Kuglica5.IsSelected = false;
                Kuglica5.Background = Brushes.LimeGreen;
                _tiket = TiketFactory.DajZelene(5);
                _mojeKuglice.Remove(Kuglica5);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica5.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica5.IsSelected = true;
            Kuglica5.Background = Brushes.Gray;
            _tiket.Brojevi.Add(5);
            _mojeKuglice.Add(Kuglica5);
        }

        private void Kuglica6_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajCrvene || AktivirajZelene || AktivirajZute) return;
            if (AktivirajRoze)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 5 && k != Kuglica6)
                        if (k.IsSelected == false) return;
                Kuglica6.IsSelected = false;
                Kuglica6.Background = Brushes.HotPink;
                _tiket = TiketFactory.DajRoze(6);
                _mojeKuglice.Remove(Kuglica6);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica6.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica6.IsSelected = true;
            Kuglica6.Background = Brushes.Gray;
            _tiket.Brojevi.Add(6);
            _mojeKuglice.Add(Kuglica6);
        }

        private void Kuglica7_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajCrvene || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajLjubicaste)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 6 && k != Kuglica7)
                        if (k.IsSelected == false) return;
                Kuglica7.IsSelected = false;
                Kuglica7.Background = Brushes.Indigo;
                _tiket = TiketFactory.DajLjubicaste(7);
                _mojeKuglice.Remove(Kuglica7);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica7.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica7.IsSelected = true;
            Kuglica7.Background = Brushes.Gray;
            _tiket.Brojevi.Add(7);
            _mojeKuglice.Add(Kuglica7);
        }

        private void Kuglica8_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajCrvene)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 0 && k != Kuglica8)
                        if (k.IsSelected == false) return;
                Kuglica8.IsSelected = false;
                Kuglica8.Background = Brushes.Red;
                _tiket = TiketFactory.DajCrvene(8);
                _mojeKuglice.Remove(Kuglica8);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica8.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica8.IsSelected = true;
            Kuglica8.Background = Brushes.Gray;
            _tiket.Brojevi.Add(8);
            _mojeKuglice.Add(Kuglica8);
        }

        private void Kuglica9_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajCrvene) return;
            if (AktivirajZute)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 1 && k != Kuglica9)
                        if (k.IsSelected == false) return;
                Kuglica9.IsSelected = false;
                Kuglica9.Background = Brushes.Yellow;
                _tiket = TiketFactory.DajZute(9);
                _mojeKuglice.Remove(Kuglica9);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica9.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica9.IsSelected = true;
            Kuglica9.Background = Brushes.Gray;
            _tiket.Brojevi.Add(9);
            _mojeKuglice.Add(Kuglica9);
        }

        private void Kuglica10_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajCrvene ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajPlave)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 2 && k != Kuglica10)
                        if (k.IsSelected == false) return;
                Kuglica10.IsSelected = false;
                Kuglica10.Background = Brushes.Blue;
                _tiket = TiketFactory.DajPlave(10);
                _mojeKuglice.Remove(Kuglica10);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica10.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica10.IsSelected = true;
            Kuglica10.Background = Brushes.Gray;
            _tiket.Brojevi.Add(10);
            _mojeKuglice.Add(Kuglica10);
        }

        private void Kuglica11_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajCrvene || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajNarandzaste)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 3 && k != Kuglica11)
                        if (k.IsSelected == false) return;
                Kuglica11.IsSelected = false;
                Kuglica11.Background = Brushes.Orange;
                _tiket = TiketFactory.DajNarandzaste(11);
                _mojeKuglice.Remove(Kuglica11);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica11.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica11.IsSelected = true;
            Kuglica11.Background = Brushes.Gray;
            _tiket.Brojevi.Add(11);
            _mojeKuglice.Add(Kuglica11);
        }

        private void Kuglica12_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajCrvene || AktivirajZute) return;
            if (AktivirajZelene)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 4 && k != Kuglica12)
                        if (k.IsSelected == false) return;
                Kuglica12.IsSelected = false;
                Kuglica12.Background = Brushes.LimeGreen;
                _tiket = TiketFactory.DajZelene(12);
                _mojeKuglice.Remove(Kuglica12);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica12.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica12.IsSelected = true;
            Kuglica12.Background = Brushes.Gray;
            _tiket.Brojevi.Add(12);
            _mojeKuglice.Add(Kuglica12);
        }

        private void Kuglica13_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajCrvene || AktivirajZelene || AktivirajZute) return;
            if (AktivirajRoze)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 5 && k != Kuglica13)
                        if (k.IsSelected == false) return;
                Kuglica13.IsSelected = false;
                Kuglica13.Background = Brushes.HotPink;
                _tiket = TiketFactory.DajRoze(13);
                _mojeKuglice.Remove(Kuglica13);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica13.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica13.IsSelected = true;
            Kuglica13.Background = Brushes.Gray;
            _tiket.Brojevi.Add(13);
            _mojeKuglice.Add(Kuglica13);
        }

        private void Kuglica14_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajCrvene || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajLjubicaste)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 6 && k != Kuglica14)
                        if (k.IsSelected == false) return;
                Kuglica14.IsSelected = false;
                Kuglica14.Background = Brushes.Indigo;
                _tiket = TiketFactory.DajLjubicaste(14);
                _mojeKuglice.Remove(Kuglica14);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica14.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica14.IsSelected = true;
            Kuglica14.Background = Brushes.Gray;
            _tiket.Brojevi.Add(14);
            _mojeKuglice.Add(Kuglica14);
        }

        private void Kuglica15_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajCrvene)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 0 && k != Kuglica15)
                        if (k.IsSelected == false) return;
                Kuglica15.IsSelected = false;
                Kuglica15.Background = Brushes.Red;
                _tiket = TiketFactory.DajCrvene(15);
                _mojeKuglice.Remove(Kuglica15);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica15.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica15.IsSelected = true;
            Kuglica15.Background = Brushes.Gray;
            _tiket.Brojevi.Add(15);
            _mojeKuglice.Add(Kuglica15);
        }

        private void Kuglica16_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajCrvene) return;
            if (AktivirajZute)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 1 && k != Kuglica16)
                        if (k.IsSelected == false) return;
                Kuglica16.IsSelected = false;
                Kuglica16.Background = Brushes.Yellow;
                _tiket = TiketFactory.DajZute(16);
                _mojeKuglice.Remove(Kuglica16);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica16.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica16.IsSelected = true;
            Kuglica16.Background = Brushes.Gray;
            _tiket.Brojevi.Add(16);
            _mojeKuglice.Add(Kuglica16);
        }

        private void Kuglica17_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajCrvene ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajPlave)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 2 && k != Kuglica17)
                        if (k.IsSelected == false) return;
                Kuglica17.IsSelected = false;
                Kuglica17.Background = Brushes.Blue;
                _tiket = TiketFactory.DajPlave(17);
                _mojeKuglice.Remove(Kuglica17);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica17.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica17.IsSelected = true;
            Kuglica17.Background = Brushes.Gray;
            _tiket.Brojevi.Add(17);
            _mojeKuglice.Add(Kuglica17);
        }

        private void Kuglica18_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajCrvene || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajNarandzaste)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 3 && k != Kuglica18)
                        if (k.IsSelected == false) return;
                Kuglica18.IsSelected = false;
                Kuglica18.Background = Brushes.Orange;
                _tiket = TiketFactory.DajNarandzaste(18);
                _mojeKuglice.Remove(Kuglica18);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica18.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica18.IsSelected = true;
            Kuglica18.Background = Brushes.Gray;
            _tiket.Brojevi.Add(18);
            _mojeKuglice.Add(Kuglica18);
        }

        private void Kuglica19_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajCrvene || AktivirajZute) return;
            if (AktivirajZelene)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 4 && k != Kuglica19)
                        if (k.IsSelected == false) return;
                Kuglica19.IsSelected = false;
                Kuglica19.Background = Brushes.LimeGreen;
                _tiket = TiketFactory.DajZelene(19);
                _mojeKuglice.Remove(Kuglica19);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica19.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica19.IsSelected = true;
            Kuglica19.Background = Brushes.Gray;
            _tiket.Brojevi.Add(19);
            _mojeKuglice.Add(Kuglica19);
        }

        private void Kuglica20_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajCrvene || AktivirajZelene || AktivirajZute) return;
            if (AktivirajRoze)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 5 && k != Kuglica20)
                        if (k.IsSelected == false) return;
                Kuglica20.IsSelected = false;
                Kuglica20.Background = Brushes.HotPink;
                _tiket = TiketFactory.DajRoze(20);
                _mojeKuglice.Remove(Kuglica20);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica20.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica20.IsSelected = true;
            Kuglica20.Background = Brushes.Gray;
            _tiket.Brojevi.Add(20);
            _mojeKuglice.Add(Kuglica20);
        }

        private void Kuglica21_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajCrvene || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajLjubicaste)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 6 && k != Kuglica21)
                        if (k.IsSelected == false) return;
                Kuglica21.IsSelected = false;
                Kuglica21.Background = Brushes.Indigo;
                _tiket = TiketFactory.DajLjubicaste(21);
                _mojeKuglice.Remove(Kuglica21);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica21.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica21.IsSelected = true;
            Kuglica21.Background = Brushes.Gray;
            _tiket.Brojevi.Add(21);
            _mojeKuglice.Add(Kuglica21);
        }

        private void Kuglica22_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajCrvene)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 0 && k != Kuglica22)
                        if (k.IsSelected == false) return;
                Kuglica22.IsSelected = false;
                Kuglica22.Background = Brushes.Red;
                _tiket = TiketFactory.DajCrvene(22);
                _mojeKuglice.Remove(Kuglica22);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica22.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica22.IsSelected = true;
            Kuglica22.Background = Brushes.Gray;
            _tiket.Brojevi.Add(22);
            _mojeKuglice.Add(Kuglica22);
        }

        private void Kuglica23_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajCrvene) return;
            if (AktivirajZute)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 1 && k != Kuglica23)
                        if (k.IsSelected == false) return;
                Kuglica23.IsSelected = false;
                Kuglica23.Background = Brushes.Yellow;
                _tiket = TiketFactory.DajZute(23);
                _mojeKuglice.Remove(Kuglica23);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica23.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica23.IsSelected = true;
            Kuglica23.Background = Brushes.Gray;
            _tiket.Brojevi.Add(23);
            _mojeKuglice.Add(Kuglica23);
        }

        private void Kuglica24_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajCrvene ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajPlave)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 2 && k != Kuglica24)
                        if (k.IsSelected == false) return;
                Kuglica24.IsSelected = false;
                Kuglica24.Background = Brushes.Blue;
                _tiket = TiketFactory.DajPlave(24);
                _mojeKuglice.Remove(Kuglica24);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica24.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica24.IsSelected = true;
            Kuglica24.Background = Brushes.Gray;
            _tiket.Brojevi.Add(24);
            _mojeKuglice.Add(Kuglica24);
        }

        private void Kuglica25_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajCrvene || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajNarandzaste)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 3 && k != Kuglica25)
                        if (k.IsSelected == false) return;
                Kuglica25.IsSelected = false;
                Kuglica25.Background = Brushes.Orange;
                _tiket = TiketFactory.DajNarandzaste(25);
                _mojeKuglice.Remove(Kuglica25);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica25.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica25.IsSelected = true;
            Kuglica25.Background = Brushes.Gray;
            _tiket.Brojevi.Add(25);
            _mojeKuglice.Add(Kuglica25);
        }

        private void Kuglica26_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajCrvene || AktivirajZute) return;
            if (AktivirajZelene)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 4 && k != Kuglica26)
                        if (k.IsSelected == false) return;
                Kuglica26.IsSelected = false;
                Kuglica26.Background = Brushes.LimeGreen;
                _tiket = TiketFactory.DajZelene(26);
                _mojeKuglice.Remove(Kuglica26);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica26.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica26.IsSelected = true;
            Kuglica26.Background = Brushes.Gray;
            _tiket.Brojevi.Add(26);
            _mojeKuglice.Add(Kuglica26);
        }

        private void Kuglica27_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajCrvene || AktivirajZelene || AktivirajZute) return;
            if (AktivirajRoze)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 5 && k != Kuglica27)
                        if (k.IsSelected == false) return;
                Kuglica27.IsSelected = false;
                Kuglica27.Background = Brushes.HotPink;
                _tiket = TiketFactory.DajRoze(27);
                _mojeKuglice.Remove(Kuglica27);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica27.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica27.IsSelected = true;
            Kuglica27.Background = Brushes.Gray;
            _tiket.Brojevi.Add(27);
            _mojeKuglice.Add(Kuglica27);
        }

        private void Kuglica28_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajCrvene || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajLjubicaste)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 6 && k != Kuglica28)
                        if (k.IsSelected == false) return;
                Kuglica28.IsSelected = false;
                Kuglica28.Background = Brushes.Indigo;
                _tiket = TiketFactory.DajLjubicaste(28);
                _mojeKuglice.Remove(Kuglica28);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica28.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica28.IsSelected = true;
            Kuglica28.Background = Brushes.Gray;
            _tiket.Brojevi.Add(28);
            _mojeKuglice.Add(Kuglica28);
        }

        private void Kuglica29_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajCrvene)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 0 && k != Kuglica29)
                        if (k.IsSelected == false) return;
                Kuglica29.IsSelected = false;
                Kuglica29.Background = Brushes.Red;
                _tiket = TiketFactory.DajCrvene(29);
                _mojeKuglice.Remove(Kuglica29);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica29.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica29.IsSelected = true;
            Kuglica29.Background = Brushes.Gray;
            _tiket.Brojevi.Add(29);
            _mojeKuglice.Add(Kuglica29);
        }

        private void Kuglica30_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajCrvene) return;
            if (AktivirajZute)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 1 && k != Kuglica30)
                        if (k.IsSelected == false) return;
                Kuglica30.IsSelected = false;
                Kuglica30.Background = Brushes.Yellow;
                _tiket = TiketFactory.DajZute(30);
                _mojeKuglice.Remove(Kuglica30);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica30.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica30.IsSelected = true;
            Kuglica30.Background = Brushes.Gray;
            _tiket.Brojevi.Add(30);
            _mojeKuglice.Add(Kuglica30);
        }

        private void Kuglica31_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajCrvene ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajPlave)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 2 && k != Kuglica31)
                        if (k.IsSelected == false) return;
                Kuglica31.IsSelected = false;
                Kuglica31.Background = Brushes.Blue;
                _tiket = TiketFactory.DajPlave(31);
                _mojeKuglice.Remove(Kuglica31);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica31.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica31.IsSelected = true;
            Kuglica31.Background = Brushes.Gray;
            _tiket.Brojevi.Add(31);
            _mojeKuglice.Add(Kuglica31);
        }

        private void Kuglica32_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajCrvene || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajNarandzaste)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 3 && k != Kuglica32)
                        if (k.IsSelected == false) return;
                Kuglica32.IsSelected = false;
                Kuglica32.Background = Brushes.Orange;
                _tiket = TiketFactory.DajNarandzaste(32);
                _mojeKuglice.Remove(Kuglica32);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica32.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica32.IsSelected = true;
            Kuglica32.Background = Brushes.Gray;
            _tiket.Brojevi.Add(32);
            _mojeKuglice.Add(Kuglica32);
        }

        private void Kuglica33_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajCrvene || AktivirajZute) return;
            if (AktivirajZelene)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 4 && k != Kuglica33)
                        if (k.IsSelected == false) return;
                Kuglica33.IsSelected = false;
                Kuglica33.Background = Brushes.LimeGreen;
                _tiket = TiketFactory.DajZelene(33);
                _mojeKuglice.Remove(Kuglica33);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica33.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica33.IsSelected = true;
            Kuglica33.Background = Brushes.Gray;
            _tiket.Brojevi.Add(33);
            _mojeKuglice.Add(Kuglica33);
        }

        private void Kuglica34_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajCrvene || AktivirajZelene || AktivirajZute) return;
            if (AktivirajRoze)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 5 && k != Kuglica34)
                        if (k.IsSelected == false) return;
                Kuglica34.IsSelected = false;
                Kuglica34.Background = Brushes.HotPink;
                _tiket = TiketFactory.DajRoze(34);
                _mojeKuglice.Remove(Kuglica34);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica34.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica34.IsSelected = true;
            Kuglica34.Background = Brushes.Gray;
            _tiket.Brojevi.Add(34);
            _mojeKuglice.Add(Kuglica34);
        }

        private void Kuglica35_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajCrvene || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajLjubicaste)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 6 && k != Kuglica35)
                        if (k.IsSelected == false) return;
                Kuglica35.IsSelected = false;
                Kuglica35.Background = Brushes.Indigo;
                _tiket = TiketFactory.DajLjubicaste(35);
                _mojeKuglice.Remove(Kuglica35);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica35.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica35.IsSelected = true;
            Kuglica35.Background = Brushes.Gray;
            _tiket.Brojevi.Add(35);
            _mojeKuglice.Add(Kuglica35);
        }

        private void Kuglica36_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajCrvene)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 0 && k != Kuglica36)
                        if (k.IsSelected == false) return;
                Kuglica36.IsSelected = false;
                Kuglica36.Background = Brushes.Red;
                _tiket = TiketFactory.DajCrvene(36);
                _mojeKuglice.Remove(Kuglica36);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica36.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica36.IsSelected = true;
            Kuglica36.Background = Brushes.Gray;
            _tiket.Brojevi.Add(36);
            _mojeKuglice.Add(Kuglica36);
        }

        private void Kuglica37_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajCrvene) return;
            if (AktivirajZute)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 1 && k != Kuglica37)
                        if (k.IsSelected == false) return;
                Kuglica37.IsSelected = false;
                Kuglica37.Background = Brushes.Yellow;
                _tiket = TiketFactory.DajZute(37);
                _mojeKuglice.Remove(Kuglica37);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica37.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica37.IsSelected = true;
            Kuglica37.Background = Brushes.Gray;
            _tiket.Brojevi.Add(37);
            _mojeKuglice.Add(Kuglica37);
        }

        private void Kuglica38_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajCrvene ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajPlave)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 2 && k != Kuglica38)
                        if (k.IsSelected == false) return;
                Kuglica38.IsSelected = false;
                Kuglica38.Background = Brushes.Blue;
                _tiket = TiketFactory.DajPlave(38);
                _mojeKuglice.Remove(Kuglica38);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica38.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica38.IsSelected = true;
            Kuglica38.Background = Brushes.Gray;
            _tiket.Brojevi.Add(38);
            _mojeKuglice.Add(Kuglica38);
        }

        private void Kuglica39_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajCrvene || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajNarandzaste)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 3 && k != Kuglica39)
                        if (k.IsSelected == false) return;
                Kuglica39.IsSelected = false;
                Kuglica39.Background = Brushes.Orange;
                _tiket = TiketFactory.DajNarandzaste(39);
                _mojeKuglice.Remove(Kuglica39);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica39.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica39.IsSelected = true;
            Kuglica39.Background = Brushes.Gray;
            _tiket.Brojevi.Add(39);
            _mojeKuglice.Add(Kuglica39);
        }

        private void Kuglica40_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajCrvene || AktivirajZute) return;
            if (AktivirajZelene)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 4 && k != Kuglica40)
                        if (k.IsSelected == false) return;
                Kuglica40.IsSelected = false;
                Kuglica40.Background = Brushes.LimeGreen;
                _tiket = TiketFactory.DajZelene(40);
                _mojeKuglice.Remove(Kuglica40);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica40.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica40.IsSelected = true;
            Kuglica40.Background = Brushes.Gray;
            _tiket.Brojevi.Add(40);
            _mojeKuglice.Add(Kuglica40);
        }

        private void Kuglica41_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajCrvene || AktivirajZelene || AktivirajZute) return;
            if (AktivirajRoze)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 5 && k != Kuglica41)
                        if (k.IsSelected == false) return;
                Kuglica41.IsSelected = false;
                Kuglica41.Background = Brushes.HotPink;
                _tiket = TiketFactory.DajRoze(41);
                _mojeKuglice.Remove(Kuglica41);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica41.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica41.IsSelected = true;
            Kuglica41.Background = Brushes.Gray;
            _tiket.Brojevi.Add(41);
            _mojeKuglice.Add(Kuglica41);
        }

        private void Kuglica42_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajCrvene || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajLjubicaste)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 6 && k != Kuglica42)
                        if (k.IsSelected == false) return;
                Kuglica42.IsSelected = false;
                Kuglica42.Background = Brushes.Indigo;
                _tiket = TiketFactory.DajLjubicaste(42);
                _mojeKuglice.Remove(Kuglica42);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica42.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica42.IsSelected = true;
            Kuglica42.Background = Brushes.Gray;
            _tiket.Brojevi.Add(42);
            _mojeKuglice.Add(Kuglica42);
        }

        private void Kuglica43_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajCrvene)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 0 && k != Kuglica43)
                        if (k.IsSelected == false) return;
                Kuglica43.IsSelected = false;
                Kuglica43.Background = Brushes.Red;
                _tiket = TiketFactory.DajCrvene(43);
                _mojeKuglice.Remove(Kuglica43);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica43.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica43.IsSelected = true;
            Kuglica43.Background = Brushes.Gray;
            _tiket.Brojevi.Add(43);
            _mojeKuglice.Add(Kuglica43);
        }

        private void Kuglica44_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajCrvene) return;
            if (AktivirajZute)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 1 && k != Kuglica44)
                        if (k.IsSelected == false) return;
                Kuglica44.IsSelected = false;
                Kuglica44.Background = Brushes.Yellow;
                _tiket = TiketFactory.DajZute(44);
                _mojeKuglice.Remove(Kuglica44);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica44.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica44.IsSelected = true;
            Kuglica44.Background = Brushes.Gray;
            _tiket.Brojevi.Add(44);
            _mojeKuglice.Add(Kuglica44);
        }

        private void Kuglica45_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajCrvene ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajPlave)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 2 && k != Kuglica45)
                        if (k.IsSelected == false) return;
                Kuglica45.IsSelected = false;
                Kuglica45.Background = Brushes.Blue;
                _tiket = TiketFactory.DajPlave(45);
                _mojeKuglice.Remove(Kuglica45);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica45.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica45.IsSelected = true;
            Kuglica45.Background = Brushes.Gray;
            _tiket.Brojevi.Add(45);
            _mojeKuglice.Add(Kuglica45);
        }

        private void Kuglica46_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajCrvene || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajNarandzaste)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 3 && k != Kuglica46)
                        if (k.IsSelected == false) return;
                Kuglica46.IsSelected = false;
                Kuglica46.Background = Brushes.Orange;
                _tiket = TiketFactory.DajNarandzaste(46);
                _mojeKuglice.Remove(Kuglica46);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica46.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica46.IsSelected = true;
            Kuglica46.Background = Brushes.Gray;
            _tiket.Brojevi.Add(46);
            _mojeKuglice.Add(Kuglica46);
        }

        private void Kuglica47_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajCrvene || AktivirajZute) return;
            if (AktivirajZelene)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 4 && k != Kuglica47)
                        if (k.IsSelected == false) return;
                Kuglica47.IsSelected = false;
                Kuglica47.Background = Brushes.LimeGreen;
                _tiket = TiketFactory.DajZelene(47);
                _mojeKuglice.Remove(Kuglica47);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica47.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica47.IsSelected = true;
            Kuglica47.Background = Brushes.Gray;
            _tiket.Brojevi.Add(47);
            _mojeKuglice.Add(Kuglica47);
        }

        private void Kuglica48_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajCrvene || AktivirajZelene || AktivirajZute) return;
            if (AktivirajRoze)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 5 && k != Kuglica48)
                        if (k.IsSelected == false) return;
                Kuglica48.IsSelected = false;
                Kuglica48.Background = Brushes.HotPink;
                _tiket = TiketFactory.DajRoze(48);
                _mojeKuglice.Remove(Kuglica48);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica48.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica48.IsSelected = true;
            Kuglica48.Background = Brushes.Gray;
            _tiket.Brojevi.Add(48);
            _mojeKuglice.Add(Kuglica48);
        }

        private void Kuglica49_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajCrvene || AktivirajNarandzaste || AktivirajPlave ||
                AktivirajRoze || AktivirajZelene || AktivirajZute) return;
            if (AktivirajLjubicaste)
            {
                foreach (Kuglice k in _kuglice)
                    if (Grid.GetColumn(k) == 6 && k != Kuglica49)
                        if (k.IsSelected == false) return;
                Kuglica49.IsSelected = false;
                Kuglica49.Background = Brushes.Indigo;
                _tiket = TiketFactory.DajLjubicaste(49);
                _mojeKuglice.Remove(Kuglica49);
                _mojeKuglice.Capacity = 6;
                return;
            }
            if (Kuglica49.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica49.IsSelected = true;
            Kuglica49.Background = Brushes.Gray;
            _tiket.Brojevi.Add(49);
            _mojeKuglice.Add(Kuglica49);
        }

        private void Automatski_Click(object sender, RoutedEventArgs e)
        {
            if (AktivirajLjubicaste || AktivirajNarandzaste || AktivirajCrvene ||
                AktivirajRoze || AktivirajZelene || AktivirajZute || AktivirajPlave) return;
            JelAutomatski = true;
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
                for (int i = 0; i < 49; i++)
                    if (broj == _kuglice[i].Broj)
                        _mojeKuglice.Add(_kuglice[i]);
            }
        }

        private void Obicni_Click(object sender, RoutedEventArgs e)
        {
            if (_tiket.Brojevi.Count < 6) {
                MessageBox.Show("Morate unijeti 6 brojeva!");
                return;
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            _tiket.ObrisiBrojeve();
            while (_mojeKuglice.Count != 0) _mojeKuglice.RemoveAt(0);
            AktivirajCrvene = false;
            AktivirajLjubicaste = false;
            AktivirajNarandzaste = false;
            AktivirajPlave = false;
            AktivirajRoze = false;
            AktivirajZelene = false;
            AktivirajZute = false;
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

        private void Zapocni_Click(object sender, RoutedEventArgs e)
        {
            if (_tiket.Brojevi.Count != 6) {
                MessageBox.Show("Morate prvo kreirati tiket!");
                return;
            }
            for (int i = 0; i < 49; i += 7)
                _kuglice[i].Background = Brushes.Red;
            for (int i = 1; i < 49; i += 7)
                _kuglice[i].Background = Brushes.Yellow;
            for (int i = 2; i < 49; i += 7)
                _kuglice[i].Background = Brushes.Blue;
            for (int i = 3; i < 49; i += 7)
                _kuglice[i].Background = Brushes.Orange;
            for (int i = 4; i < 49; i += 7)
                _kuglice[i].Background = Brushes.LimeGreen;
            for (int i = 5; i < 49; i += 7)
                _kuglice[i].Background = Brushes.HotPink;
            for (int i = 6; i < 49; i += 7)
                _kuglice[i].Background = Brushes.Indigo;
            _mojeKuglice=_mojeKuglice.OrderBy(Kuglice => Kuglice.Broj).ToList();
            IzvlacenjeBrojeva novi = new IzvlacenjeBrojeva(_tiket, _mojeKuglice);
            this.Close();
            novi.Show();
        }
    }
}

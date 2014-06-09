﻿using System;
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
            AktivirajCrvene = true;
            foreach (Kuglice k in _kuglice)
                if (Grid.GetColumn(k) == 0)
                {
                    k.Background = Brushes.Gray;
                    k.IsSelected = true;
                    k.Boja = "Crvene";
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
                    k.Boja = "Zute";
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
                    k.Boja = "Plave";
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
                    k.Boja = "Narandzaste";
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
                    k.Boja = "Zelene";
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
                    k.Boja = "Roze";
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
                    k.Boja = "Ljubicaste";
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
            if (Kuglica1.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica1.IsSelected = true;
            Kuglica1.Background = Brushes.Gray;
            _tiket.Brojevi.Add(1);
            _mojeKuglice.Add(Kuglica1);
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
            if (Kuglica2.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica2.IsSelected = true;
            Kuglica2.Background = Brushes.Gray;
            _tiket.Brojevi.Add(2);
            _mojeKuglice.Add(Kuglica2);
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
            if (Kuglica3.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica3.IsSelected = true;
            Kuglica3.Background = Brushes.Gray;
            _tiket.Brojevi.Add(3);
            _mojeKuglice.Add(Kuglica3);
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
            if (Kuglica4.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica4.IsSelected = true;
            Kuglica4.Background = Brushes.Gray;
            _tiket.Brojevi.Add(4);
            _mojeKuglice.Add(Kuglica4);
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
            if (Kuglica5.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica5.IsSelected = true;
            Kuglica5.Background = Brushes.Gray;
            _tiket.Brojevi.Add(5);
            _mojeKuglice.Add(Kuglica5);
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
            if (Kuglica6.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica6.IsSelected = true;
            Kuglica6.Background = Brushes.Gray;
            _tiket.Brojevi.Add(6);
            _mojeKuglice.Add(Kuglica6);
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
            if (Kuglica7.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica7.IsSelected = true;
            Kuglica7.Background = Brushes.Gray;
            _tiket.Brojevi.Add(7);
            _mojeKuglice.Add(Kuglica7);
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
            if (Kuglica8.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica8.IsSelected = true;
            Kuglica8.Background = Brushes.Gray;
            _tiket.Brojevi.Add(8);
            _mojeKuglice.Add(Kuglica8);
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
            if (Kuglica9.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica9.IsSelected = true;
            Kuglica9.Background = Brushes.Gray;
            _tiket.Brojevi.Add(9);
            _mojeKuglice.Add(Kuglica9);
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
            if (Kuglica10.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica10.IsSelected = true;
            Kuglica10.Background = Brushes.Gray;
            _tiket.Brojevi.Add(10);
            _mojeKuglice.Add(Kuglica10);
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
            if (Kuglica11.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica11.IsSelected = true;
            Kuglica11.Background = Brushes.Gray;
            _tiket.Brojevi.Add(11);
            _mojeKuglice.Add(Kuglica11);
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
            if (Kuglica12.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica12.IsSelected = true;
            Kuglica12.Background = Brushes.Gray;
            _tiket.Brojevi.Add(12);
            _mojeKuglice.Add(Kuglica12);
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
            if (Kuglica13.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica13.IsSelected = true;
            Kuglica13.Background = Brushes.Gray;
            _tiket.Brojevi.Add(13);
            _mojeKuglice.Add(Kuglica13);
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
            if (Kuglica14.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica14.IsSelected = true;
            Kuglica14.Background = Brushes.Gray;
            _tiket.Brojevi.Add(14);
            _mojeKuglice.Add(Kuglica14);
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
            if (Kuglica15.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica15.IsSelected = true;
            Kuglica15.Background = Brushes.Gray;
            _tiket.Brojevi.Add(15);
            _mojeKuglice.Add(Kuglica15);
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
            if (Kuglica16.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica16.IsSelected = true;
            Kuglica16.Background = Brushes.Gray;
            _tiket.Brojevi.Add(16);
            _mojeKuglice.Add(Kuglica16);
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
            if (Kuglica17.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica17.IsSelected = true;
            Kuglica17.Background = Brushes.Gray;
            _tiket.Brojevi.Add(17);
            _mojeKuglice.Add(Kuglica17);
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
            if (Kuglica18.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica18.IsSelected = true;
            Kuglica18.Background = Brushes.Gray;
            _tiket.Brojevi.Add(18);
            _mojeKuglice.Add(Kuglica18);
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
            if (Kuglica19.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica19.IsSelected = true;
            Kuglica19.Background = Brushes.Gray;
            _tiket.Brojevi.Add(19);
            _mojeKuglice.Add(Kuglica19);
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
            if (Kuglica20.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica20.IsSelected = true;
            Kuglica20.Background = Brushes.Gray;
            _tiket.Brojevi.Add(20);
            _mojeKuglice.Add(Kuglica20);
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
            if (Kuglica21.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica21.IsSelected = true;
            Kuglica21.Background = Brushes.Gray;
            _tiket.Brojevi.Add(21);
            _mojeKuglice.Add(Kuglica21);
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
            if (Kuglica22.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica22.IsSelected = true;
            Kuglica22.Background = Brushes.Gray;
            _tiket.Brojevi.Add(22);
            _mojeKuglice.Add(Kuglica22);
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
            if (Kuglica23.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica23.IsSelected = true;
            Kuglica23.Background = Brushes.Gray;
            _tiket.Brojevi.Add(23);
            _mojeKuglice.Add(Kuglica23);
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
            if (Kuglica24.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica24.IsSelected = true;
            Kuglica24.Background = Brushes.Gray;
            _tiket.Brojevi.Add(24);
            _mojeKuglice.Add(Kuglica24);
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
            if (Kuglica25.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica25.IsSelected = true;
            Kuglica25.Background = Brushes.Gray;
            _tiket.Brojevi.Add(25);
            _mojeKuglice.Add(Kuglica25);
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
            if (Kuglica26.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica26.IsSelected = true;
            Kuglica26.Background = Brushes.Gray;
            _tiket.Brojevi.Add(26);
            _mojeKuglice.Add(Kuglica26);
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
            if (Kuglica27.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica27.IsSelected = true;
            Kuglica27.Background = Brushes.Gray;
            _tiket.Brojevi.Add(27);
            _mojeKuglice.Add(Kuglica27);
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
            if (Kuglica28.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica28.IsSelected = true;
            Kuglica28.Background = Brushes.Gray;
            _tiket.Brojevi.Add(28);
            _mojeKuglice.Add(Kuglica28);
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
            if (Kuglica29.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica29.IsSelected = true;
            Kuglica29.Background = Brushes.Gray;
            _tiket.Brojevi.Add(29);
            _mojeKuglice.Add(Kuglica29);
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
            if (Kuglica30.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica30.IsSelected = true;
            Kuglica30.Background = Brushes.Gray;
            _tiket.Brojevi.Add(30);
            _mojeKuglice.Add(Kuglica30);
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
            if (Kuglica31.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica31.IsSelected = true;
            Kuglica31.Background = Brushes.Gray;
            _tiket.Brojevi.Add(31);
            _mojeKuglice.Add(Kuglica31);
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
            if (Kuglica32.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica32.IsSelected = true;
            Kuglica32.Background = Brushes.Gray;
            _tiket.Brojevi.Add(32);
            _mojeKuglice.Add(Kuglica32);
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
            if (Kuglica33.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica33.IsSelected = true;
            Kuglica33.Background = Brushes.Gray;
            _tiket.Brojevi.Add(33);
            _mojeKuglice.Add(Kuglica33);
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
            if (Kuglica34.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica34.IsSelected = true;
            Kuglica34.Background = Brushes.Gray;
            _tiket.Brojevi.Add(34);
            _mojeKuglice.Add(Kuglica34);
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
            if (Kuglica35.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica35.IsSelected = true;
            Kuglica35.Background = Brushes.Gray;
            _tiket.Brojevi.Add(35);
            _mojeKuglice.Add(Kuglica35);
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
            if (Kuglica36.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica36.IsSelected = true;
            Kuglica36.Background = Brushes.Gray;
            _tiket.Brojevi.Add(36);
            _mojeKuglice.Add(Kuglica36);
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
            if (Kuglica37.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica37.IsSelected = true;
            Kuglica37.Background = Brushes.Gray;
            _tiket.Brojevi.Add(37);
            _mojeKuglice.Add(Kuglica37);
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
            if (Kuglica38.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica38.IsSelected = true;
            Kuglica38.Background = Brushes.Gray;
            _tiket.Brojevi.Add(38);
            _mojeKuglice.Add(Kuglica38);
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
            if (Kuglica39.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica39.IsSelected = true;
            Kuglica39.Background = Brushes.Gray;
            _tiket.Brojevi.Add(39);
            _mojeKuglice.Add(Kuglica39);
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
            if (Kuglica40.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica40.IsSelected = true;
            Kuglica40.Background = Brushes.Gray;
            _tiket.Brojevi.Add(40);
            _mojeKuglice.Add(Kuglica40);
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
            if (Kuglica41.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica41.IsSelected = true;
            Kuglica41.Background = Brushes.Gray;
            _tiket.Brojevi.Add(41);
            _mojeKuglice.Add(Kuglica41);
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
            if (Kuglica42.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica42.IsSelected = true;
            Kuglica42.Background = Brushes.Gray;
            _tiket.Brojevi.Add(42);
            _mojeKuglice.Add(Kuglica42);
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
            if (Kuglica43.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica43.IsSelected = true;
            Kuglica43.Background = Brushes.Gray;
            _tiket.Brojevi.Add(43);
            _mojeKuglice.Add(Kuglica43);
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
            if (Kuglica44.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica44.IsSelected = true;
            Kuglica44.Background = Brushes.Gray;
            _tiket.Brojevi.Add(44);
            _mojeKuglice.Add(Kuglica44);
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
            if (Kuglica45.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica45.IsSelected = true;
            Kuglica45.Background = Brushes.Gray;
            _tiket.Brojevi.Add(45);
            _mojeKuglice.Add(Kuglica45);
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
            if (Kuglica46.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica46.IsSelected = true;
            Kuglica46.Background = Brushes.Gray;
            _tiket.Brojevi.Add(46);
            _mojeKuglice.Add(Kuglica46);
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
            if (Kuglica47.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica47.IsSelected = true;
            Kuglica47.Background = Brushes.Gray;
            _tiket.Brojevi.Add(47);
            _mojeKuglice.Add(Kuglica47);
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
            if (Kuglica48.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica48.IsSelected = true;
            Kuglica48.Background = Brushes.Gray;
            _tiket.Brojevi.Add(48);
            _mojeKuglice.Add(Kuglica48);
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
            if (Kuglica49.IsSelected) return;
            if (_tiket.Brojevi.Count == 6) return;
            Kuglica49.IsSelected = true;
            Kuglica49.Background = Brushes.Gray;
            _tiket.Brojevi.Add(49);
            _mojeKuglice.Add(Kuglica49);
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
                for (int i = 0; i < 49; i++)
                    if (broj == _kuglice[i].Broj)
                        _mojeKuglice.Add(_kuglice[i]);
            }
            string ispis = Convert.ToString(_tiket.Brojevi[0]) + " " + Convert.ToString(_tiket.Brojevi[1]) + " " + Convert.ToString(_tiket.Brojevi[2]) +
               " " + Convert.ToString(_tiket.Brojevi[3]) + " " + Convert.ToString(_tiket.Brojevi[4]) + " " + Convert.ToString(_tiket.Brojevi[5]);
            MessageBox.Show(ispis);
        }

        private void Obicni_Click(object sender, RoutedEventArgs e)
        {
            if (_tiket.Brojevi.Count < 6) {
                MessageBox.Show("Morate unijeti 6 brojeva!");
                return;
            }
            _tiket = TiketFactory.DajNormalni(_tiket);
            string ispis = Convert.ToString(_tiket.Brojevi[0]) + " " + Convert.ToString(_tiket.Brojevi[1]) + " " + Convert.ToString(_tiket.Brojevi[2]) +
               " " + Convert.ToString(_tiket.Brojevi[3]) + " " + Convert.ToString(_tiket.Brojevi[4]) + " " + Convert.ToString(_tiket.Brojevi[5]);
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

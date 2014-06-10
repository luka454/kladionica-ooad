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
using System.Windows.Shapes;

namespace Bingo
{
    /// <summary>
    /// Interaction logic for IzvlacenjeBrojeva.xaml
    /// </summary>
    public partial class IzvlacenjeBrojeva : Window
    {
        public Igra49 TrenutnaIgra { get; set; }
        public List<Kuglice> _kuglice { get; set; }
        public List<Kuglice> _mojeKuglice { get; set; }
        public IzvlacenjeBrojeva()
        {
            InitializeComponent();
        }
        public IzvlacenjeBrojeva(Tiket6 _tiket, List<Kuglice> _mojeKuglice)
        {
            InitializeComponent();
            TrenutnaIgra = new Igra49();
            this.Title = "Bingo";
            this._mojeKuglice = _mojeKuglice;
            _kuglice = new List<Kuglice>();
            TrenutnaIgra.Tiket = _tiket;
            PostaviKuglice();
            foreach (var item in grid1.Children)
            {
                if (item is Kuglice)
                {
                    _kuglice.Add((Kuglice)item);
                    ((Kuglice)item).Visibility = Visibility.Hidden;
                }
            }
        }

        private void PostaviKuglice()
        {
            KuglicaA.Content = _mojeKuglice[0].Content;
            KuglicaB.Content = _mojeKuglice[1].Content;
            KuglicaC.Content = _mojeKuglice[2].Content;
            KuglicaD.Content = _mojeKuglice[3].Content;
            KuglicaE.Content = _mojeKuglice[4].Content;
            KuglicaF.Content = _mojeKuglice[5].Content;
        }

        private void Sljedeci_Click(object sender, RoutedEventArgs e)
        {
            //if (_kuglice[34].Visibility == Visibility.Visible)
            //{
            //    osvojili.Visibility = Visibility.Visible;
            //    pobjeda.Content = TrenutnaIgra.Dobitak + " KM";
            //    return;
            //}
            int broj = TrenutnaIgra.DajSljedeciBroj();
            if (TrenutnaIgra.Tiket.Obavijesti(broj))
            {
                TrenutnaIgra.Tiket.Brojac++;
                if (_mojeKuglice[0].Broj == broj) KuglicaA.Background = _mojeKuglice[0].Background;
                else if (_mojeKuglice[1].Broj == broj) KuglicaB.Background = _mojeKuglice[1].Background;
                else if (_mojeKuglice[2].Broj == broj) KuglicaC.Background = _mojeKuglice[2].Background;
                else if (_mojeKuglice[3].Broj == broj) KuglicaD.Background = _mojeKuglice[3].Background;
                else if (_mojeKuglice[4].Broj == broj) KuglicaE.Background = _mojeKuglice[4].Background;
                else if (_mojeKuglice[5].Broj == broj) KuglicaF.Background = _mojeKuglice[5].Background;
            }
            for (int i = 0; i < 35; i++)
            {
                if (_kuglice[i].Visibility == Visibility.Hidden)
                {
                    _kuglice[i].Visibility = Visibility.Visible;
                    _kuglice[i].Broj = broj;
                    _kuglice[i].Content = broj;
                    _kuglice[i].OdrediBoju(broj);
                    switch (_kuglice[i].Boja)
                    {
                        case "Crvene":
                            _kuglice[i].Background = Brushes.Red;
                            break;
                        case "Zute":
                            _kuglice[i].Background = Brushes.Yellow;
                            break;
                        case "Plave":
                            _kuglice[i].Background = Brushes.Blue;
                            break;
                        case "Narandzaste":
                            _kuglice[i].Background = Brushes.Orange;
                            break;
                        case "Zelene":
                            _kuglice[i].Background = Brushes.LimeGreen;
                            break;
                        case "Roze":
                            _kuglice[i].Background = Brushes.HotPink;
                            break;
                        case "Ljubicaste":
                            _kuglice[i].Background = Brushes.Indigo;
                            break;
                    }
                    return;
                }
            }            
        }

        private void Dobitak()
        {
            if (_kuglice[5].Visibility == Visibility.Visible && _kuglice[6].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 10000;
            else if (_kuglice[6].Visibility == Visibility.Visible && _kuglice[7].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 7500;
            else if (_kuglice[7].Visibility == Visibility.Visible && _kuglice[8].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 5000;
            else if (_kuglice[8].Visibility == Visibility.Visible && _kuglice[9].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 2500;
            else if (_kuglice[9].Visibility == Visibility.Visible && _kuglice[10].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 1000;
            else if (_kuglice[10].Visibility == Visibility.Visible && _kuglice[11].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 500;
            else if (_kuglice[11].Visibility == Visibility.Visible && _kuglice[12].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 300;
            else if (_kuglice[12].Visibility == Visibility.Visible && _kuglice[13].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 200;
            else if (_kuglice[13].Visibility == Visibility.Visible && _kuglice[14].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 150;
            else if (_kuglice[14].Visibility == Visibility.Visible && _kuglice[15].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 100;
            else if (_kuglice[15].Visibility == Visibility.Visible && _kuglice[16].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 90;
            else if (_kuglice[16].Visibility == Visibility.Visible && _kuglice[17].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 80;
            else if (_kuglice[17].Visibility == Visibility.Visible && _kuglice[18].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 70;
            else if (_kuglice[18].Visibility == Visibility.Visible && _kuglice[19].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 60;
            else if (_kuglice[19].Visibility == Visibility.Visible && _kuglice[20].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 50;
            else if (_kuglice[20].Visibility == Visibility.Visible && _kuglice[21].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 40;
            else if (_kuglice[21].Visibility == Visibility.Visible && _kuglice[22].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 30;
            else if (_kuglice[22].Visibility == Visibility.Visible && _kuglice[23].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 25;
            else if (_kuglice[23].Visibility == Visibility.Visible && _kuglice[24].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 20;
            else if (_kuglice[24].Visibility == Visibility.Visible && _kuglice[25].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 15;
            else if (_kuglice[25].Visibility == Visibility.Visible && _kuglice[26].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 10;
            else if (_kuglice[26].Visibility == Visibility.Visible && _kuglice[27].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 9;
            else if (_kuglice[27].Visibility == Visibility.Visible && _kuglice[28].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 8;
            else if (_kuglice[28].Visibility == Visibility.Visible && _kuglice[29].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 7;
            else if (_kuglice[29].Visibility == Visibility.Visible && _kuglice[30].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 6;
            else if (_kuglice[30].Visibility == Visibility.Visible && _kuglice[31].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 5;
            else if (_kuglice[31].Visibility == Visibility.Visible && _kuglice[32].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 4;
            else if (_kuglice[32].Visibility == Visibility.Visible && _kuglice[33].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 3;
            else if (_kuglice[33].Visibility == Visibility.Visible && _kuglice[34].Visibility == Visibility.Hidden)
                TrenutnaIgra.Dobitak = 2;
            else if (_kuglice[34].Visibility == Visibility.Visible)
                TrenutnaIgra.Dobitak = 1;
            else TrenutnaIgra.Dobitak = 0;
        }

        private void Novi_Click(object sender, RoutedEventArgs e)
        {
            IzaberiBrojeve novi = new IzaberiBrojeve();
            this.Close();
            novi.Show();
        }

        private void PrikaziPoruku(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (TrenutnaIgra.Tiket.JelDobitni() && TrenutnaIgra.Dobitak == 0) Dobitak();
            osvojili.Visibility = Visibility.Visible;
            pobjeda.Content = TrenutnaIgra.Dobitak + " KM";
        }
    }
}

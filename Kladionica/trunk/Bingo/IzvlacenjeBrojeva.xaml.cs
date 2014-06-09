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
            //
            KuglicaA.Content = _mojeKuglice[0].Content;

            //KuglicaB.Background = _mojeKuglice[1].Background;
            KuglicaB.Content = _mojeKuglice[1].Content;

            //KuglicaC.Background = _mojeKuglice[2].Background;
            KuglicaC.Content = _mojeKuglice[2].Content;

            //KuglicaD.Background = _mojeKuglice[3].Background;
            KuglicaD.Content = _mojeKuglice[3].Content;

            //KuglicaE.Background = _mojeKuglice[4].Background;
            KuglicaE.Content = _mojeKuglice[4].Content;

            //KuglicaF.Background = _mojeKuglice[5].Background;
            KuglicaF.Content = _mojeKuglice[5].Content;
        }

        private void Sljedeci_Click(object sender, RoutedEventArgs e)
        {
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
    }
}

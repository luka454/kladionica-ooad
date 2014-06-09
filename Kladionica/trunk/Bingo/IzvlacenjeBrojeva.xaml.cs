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
        public IzvlacenjeBrojeva(Tiket6 _tiket, List<Kuglice> _kuglice, List<Kuglice> _mojeKuglice)
        {
            InitializeComponent();
            TrenutnaIgra = new Igra49();
            this.Title = "Bingo";
            this._kuglice = _kuglice;
            this._mojeKuglice = _mojeKuglice;
            TrenutnaIgra.Tiket = _tiket;
            PostaviKuglice();
            if (Grid.NameProperty.Name == "grid1")
                foreach (Kuglice k in grid1.Children)
                    k.Visibility = Visibility.Hidden;
        }

        private void PostaviKuglice()
        {
            KuglicaA.Background = _mojeKuglice[0].Background;
            KuglicaA.Content = _mojeKuglice[0].Content;

            KuglicaB.Background = _mojeKuglice[1].Background;
            KuglicaB.Content = _mojeKuglice[1].Content;

            KuglicaC.Background = _mojeKuglice[2].Background;
            KuglicaC.Content = _mojeKuglice[2].Content;

            KuglicaD.Background = _mojeKuglice[3].Background;
            KuglicaD.Content = _mojeKuglice[3].Content;

            KuglicaE.Background = _mojeKuglice[4].Background;
            KuglicaE.Content = _mojeKuglice[4].Content;

            KuglicaF.Background = _mojeKuglice[5].Background;
            KuglicaF.Content = _mojeKuglice[5].Content;
        }
    }
}

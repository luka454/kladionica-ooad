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
        }

        private void PostaviKuglice()
        {
            Kuglica1.Background = _mojeKuglice[0].Background;
            Kuglica1.Content = _mojeKuglice[0].Content;

            Kuglica2.Background = _mojeKuglice[1].Background;
            Kuglica2.Content = _mojeKuglice[1].Content;

            Kuglica3.Background = _mojeKuglice[2].Background;
            Kuglica3.Content = _mojeKuglice[2].Content;

            Kuglica4.Background = _mojeKuglice[3].Background;
            Kuglica4.Content = _mojeKuglice[3].Content;

            Kuglica5.Background = _mojeKuglice[4].Background;
            Kuglica5.Content = _mojeKuglice[4].Content;

            Kuglica6.Background = _mojeKuglice[5].Background;
            Kuglica6.Content = _mojeKuglice[5].Content;
        }
    }
}

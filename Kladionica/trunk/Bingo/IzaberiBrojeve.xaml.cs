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
    /// Interaction logic for IzaberiBrojeve.xaml
    /// </summary>
    public partial class IzaberiBrojeve : Window
    {
        public List<Kuglice> _kuglice { get; set; }
        public IzaberiBrojeve()
        {
            InitializeComponent();
            foreach (var  item in sveaaa.Children)
            {
                if (item is Kuglice)
                {
                    _kuglice.Add( (Kuglice)item);
                }
            }
        }

        private void CrveneButton_Click(object sender, RoutedEventArgs e)
        {
            if (Kuglica1.IsSelected) TiketFactory.DajCrvene(1);
            else if (Kuglica8.IsSelected) TiketFactory.DajCrvene(8);
            else if (Kuglica15.IsSelected) TiketFactory.DajCrvene(15);
            else if (Kuglica22.IsSelected) TiketFactory.DajCrvene(22);
            else if (Kuglica29.IsSelected) TiketFactory.DajCrvene(29);
            else if (Kuglica36.IsSelected) TiketFactory.DajCrvene(36);
            else if (Kuglica43.IsSelected) TiketFactory.DajCrvene(43);
            else return;
        }

        private void ZuteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PlaveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NarandzasteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ZeleneButton_Click(object sender, RoutedEventArgs e)
        {

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
            for (int i = 0; i < length; i++)
            {
                
            }
        }
    }
}

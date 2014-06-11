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
using Kladionica.AdministracijaIgre;

namespace Kladionica
{
    /// <summary>
    /// Interaction logic for AdministracijaWindow.xaml
    /// </summary>
    public partial class AdministracijaWindow : Window
    {
        
        public AdministracijaWindow()
        {
            InitializeComponent();
        }

        private void BDodajIgre_Click_1(object sender, RoutedEventArgs e)
        {
            Stranica.Content = new AdministracijaIgre.DodavanjeIgre(this);
        }
    }
}

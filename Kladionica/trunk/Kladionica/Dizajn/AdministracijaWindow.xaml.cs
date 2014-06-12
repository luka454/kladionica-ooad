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
            Stranica.Content = new Welcome();
        }

        private void BDodajIgre_Click_1(object sender, RoutedEventArgs e)
        {
            DodavanjeIgre dodaj = new DodavanjeIgre(Stranica);
            dodaj.Show();
        }

        private void BLogOut_Click_1(object sender, RoutedEventArgs e)
        {
            Window novi = new MainWindow();
            App.Current.MainWindow = novi;
            this.Close();
            novi.Show();
        }
    }
}

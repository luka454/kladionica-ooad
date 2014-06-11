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
using Kladionica.BazaPodataka;

namespace Kladionica.AdministracijaIgre
{
    /// <summary>
    /// Interaction logic for DodavanjeIgre.xaml
    /// </summary>
    public partial class DodavanjeIgre : Window
    {
        public DodavanjeIgre()
        {
            InitializeComponent();
        }

        private void OdustaniF_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OdustaniT_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

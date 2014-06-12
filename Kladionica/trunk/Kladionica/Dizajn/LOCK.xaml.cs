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

namespace Kladionica.Dizajn
{
    /// <summary>
    /// Interaction logic for LOCK.xaml
    /// </summary>
    public partial class LOCK : Window
    {
        Radnica r;
        public LOCK(Radnica rad)
        {
            r = rad;
            InitializeComponent();
            label.Text += "  " + r.Username;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (r.HashPassword != Administracija.HashPassFunkcija(Password.Password))
            {
                MessageBox.Show("Pogrešan password");
            }
            else
            {
                RadnikPocetna novi = new RadnikPocetna(r);
                App.Current.MainWindow = novi;
                this.Close();
                novi.Show();
            }
            
        }
    }
}

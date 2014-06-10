using Kladionica.BazaPodataka;
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

namespace Kladionica
{
    /// <summary>
    /// Interaction logic for RegistrujKorisnika.xaml
    /// </summary>
    public partial class RegistrujKorisnika : Window
    {
        public RegistrujKorisnika()
        {
            InitializeComponent();
        }
        ContentPresenter _c;
        public RegistrujKorisnika(ContentPresenter c)
        {
            InitializeComponent();
            _c = c;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClanKlubaDAO baza = BazaPodataka.DAL.Factory.getClanKlubaDao();
            ClanKluba c = baza.getByUsername(UserBox.Text);
            if(c != null)
            if(ClanKluba.HashFunkcijaSifra(PassBox.Password) == c.HashPassword)
            {
                _c.Content = new PrikazKorisnika(c, _c);
                this.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Pogresna sifra!");
            }
            else System.Windows.MessageBox.Show("Pogresan username!");
        }
    }
}

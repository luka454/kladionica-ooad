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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kladionica
{
    /// <summary>
    /// Interaction logic for AfterBKorisKlubClick.xaml
    /// </summary>
    public partial class AfterBKorisKlubClick : ContentControl
    {
        public AfterBKorisKlubClick()
        {
            InitializeComponent();
        }
        private ContentPresenter _c;
        public AfterBKorisKlubClick(ContentPresenter c)
        {
            InitializeComponent();
            _c = c;
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            _c.Content = new UnosKorisnika(_c);
        }

        private void InfoOKorisniku_Click(object sender, RoutedEventArgs e)
        {
            RegistrujKorisnika p = new RegistrujKorisnika();
            p.Show();
        }
    }
}

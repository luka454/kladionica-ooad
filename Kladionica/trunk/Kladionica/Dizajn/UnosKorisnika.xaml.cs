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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kladionica
{
    /// <summary>
    /// Interaction logic for UnosKorisnika.xaml
    /// </summary>
    public partial class UnosKorisnika : ContentControl
    {
        private ContentPresenter _c;
        public UnosKorisnika()
        {
            InitializeComponent();
        }

        public UnosKorisnika(ContentPresenter c)
        {
            _c = c;
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _c.Content = new AfterBKorisKlubClick(_c);
        }

        private void PassCheckBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password != PassCheckBox.Password) 
            {
                ErrorText.Foreground = Brushes.Red;
                ErrorBorder.BorderBrush = Brushes.Red;
                KreirajButton.IsEnabled = false;
            }
            else
            {
                ErrorText.Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString("#00bbff");
                ErrorBorder.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFromString("#00bbff");
                KreirajButton.IsEnabled = true;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ClanKlubaDAO baza = BazaPodataka.DAL.Factory.getClanKlubaDao();
            baza.create(new ClanKluba(ImeBox.Text, PrezimeBox.Text, UsernameBox.Text, PasswordBox.Password, Convert.ToInt32(PINBox.Text)));
        }
    }
}

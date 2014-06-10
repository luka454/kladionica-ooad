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
using Kladionica.Dizajn;

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
            //_c.Content = new AfterBKorisKlubClick(_c);
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
            if(validirano())
            {
                ClanKlubaDAO baza = BazaPodataka.DAL.Factory.getClanKlubaDao();
                baza.create(new ClanKluba(ImeBox.Text, PrezimeBox.Text, UsernameBox.Text, PasswordBox.Password, Convert.ToInt32(PINBox.Password)));
                _c.Content = new DobarUnos();
            

            }
            else
            {

            }
            
        }

        private bool validirano()
        {
            if (UsernameBox.Text.Length < 2) return false;
            if (ImeBox.Text.Length < 2) return false;
            if (PrezimeBox.Text.Length < 2) return false;
            if (PasswordBox.Password.Length < 2) return false;
            if (PassCheckBox.Password.Length < 2) return false;
            if (PINBox.Password.Length < 2) return false;
            if (IsNotAllDigit(PINBox.Password)) return false;
            return true;
        }

        private bool IsNotAllDigit(string p)
        {
            for (int i = 0; i < p.Length; i++)
                if (p[i] < '0' || p[i] > '9') return true;
            return false;
        }
    }
}

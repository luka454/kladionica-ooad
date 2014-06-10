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
    /// Interaction logic for EditKorisnika.xaml
    /// </summary>
    public partial class EditKorisnika : ContentControl
    {
        public EditKorisnika()
        {
            InitializeComponent();
        }
        ContentPresenter _p;
        ClanKluba ck;
        public EditKorisnika(ContentPresenter p, ClanKluba c)
        {
            InitializeComponent();
            _p = p;
            ck = c;
            ImeBox.Text = ck.Ime;
            PrezimeBox.Text = ck.Prezime;
            UsernameBox.Text = ck.Username;
        }
        private void PassCheckBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PassBox.Password != PassCheckBox.Password)
            {
                ErrorText.Foreground = Brushes.Red;
                ErrorBorder.BorderBrush = Brushes.Red;
                SpremiButton.IsEnabled = false;
            }
            else
            {
                ErrorText.Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString("#00bbff");
                ErrorBorder.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFromString("#00bbff");
                SpremiButton.IsEnabled = true;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (validirano())
            {
                ck.Ime = ImeBox.Text;
                ck.Prezime = PrezimeBox.Text;
                ck.Username = UsernameBox.Text;
                if ((bool)PassChange.IsChecked) ck.HashPassword = ClanKluba.HashFunkcijaSifra(PassBox.Password);
                ClanKlubaDAO baza = BazaPodataka.DAL.Factory.getClanKlubaDao();
                baza.update(ck);
                _p.Content = new DobarUnos("Promjene uspjesno izvrsene!");
                TheEnclosingMethod();
            }
            else
            {
                System.Windows.MessageBox.Show("Greska prilikom unosa parametara! Unesite ponovo.");
                _p.Content = new EditKorisnika(_p, ck);
            }
        }
        public async void TheEnclosingMethod()
        {

            await Task.Delay(2000);
            _p.Content = new PrikazKorisnika(ck, _p);
        }

        private bool validirano()
        {
            if (UsernameBox.Text.Length < 2) return false;
            if (ImeBox.Text.Length < 2) return false;
            if (PrezimeBox.Text.Length < 2) return false;
            if((bool)PassChange.IsChecked) if (PassBox.Password.Length < 2) return false;
            if ((bool)PassChange.IsChecked) if (PassCheckBox.Password.Length < 2) return false;
            return true;
        }

        private void CheckBox_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
        }

        private void PassChange_Unchecked(object sender, RoutedEventArgs e)
        {
            PassBox.IsEnabled = false;
            PassCheckBox.IsEnabled = false;
        }

        private void PassChange_Checked(object sender, RoutedEventArgs e)
        {
            PassBox.IsEnabled = true;
            PassCheckBox.IsEnabled = true;
        }

    }
}

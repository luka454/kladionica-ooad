using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for LogInScreen.xaml
    /// </summary>
    public partial class LogInScreen : Page
    {
        public LogInScreen()
        {
            InitializeComponent();
            
        }

        private void UserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try

            {
                
                if (Username.Text.Equals(String.Empty))
                {
                    ErrorPanel.Visibility = Visibility.Visible;
                    ErrorMessage.Text = "!! Niste unijeli username";

                    return;
                }

                
                Radnica r = BazaPodataka.DAL.Factory.getRadnicaDAO().getByUsername(Username.Text);

                if (r == null)
                {
                    ErrorPanel.Visibility = Visibility.Visible;
                    ErrorMessage.Text = "!! Uneseni username nije pronadjen";

                    return;
                }

                if (r.HashPassword != Administracija.HashPassFunkcija(Password.Password))
                {
                    ErrorPanel.Visibility = Visibility.Visible;
                    ErrorMessage.Text = "!! Uneseni password nije točan";

                    return;
                }

                MainWindow w = Window.GetWindow(this) as MainWindow;

                RadnikPocetna novi = new RadnikPocetna(r);
                App.Current.MainWindow = novi;
                w.Close();
                novi.Show();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Radnica r = new Radnica("Luka", "Pejović", "luka454", 000, 5000M);

            MainWindow w = Window.GetWindow(this) as MainWindow;

            RadnikPocetna novi = new RadnikPocetna(r);
            App.Current.MainWindow = novi;
            w.Close();
            novi.Show();
        }
    }
}

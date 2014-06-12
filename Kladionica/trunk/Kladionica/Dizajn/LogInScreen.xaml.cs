using MySql.Data.MySqlClient;
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
        Point currentPoint = new Point();
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

                if (Username.Text.ToLower() == "administracija")
                {
                    MainWindow we = Window.GetWindow(this) as MainWindow;

                    Window novi2 = new AdministracijaWindow();
                    App.Current.MainWindow = novi2;
                    we.Close();
                    novi2.Show();
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

                BazaPodataka.DAL.Connection.Open();
                string cmd = String.Format("insert into dolazaknaposao values ('{0}', '{1}')",r.ID,DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                MySqlCommand c = new MySqlCommand(cmd, BazaPodataka.DAL.Connection);
                c.ExecuteNonQuery();
                BazaPodataka.DAL.Connection.Close();

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
            r.ID = 0;

            MainWindow w = Window.GetWindow(this) as MainWindow;

            RadnikPocetna novi = new RadnikPocetna(r);
            App.Current.MainWindow = novi;
            w.Close();
            novi.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow w = Window.GetWindow(this) as MainWindow;

            Window novi = new AdministracijaWindow();
            App.Current.MainWindow = novi;
            w.Close();
            novi.Show();
        }

        private void canvas_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
                currentPoint = e.GetPosition(this);
        }

        private void canvas_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Line line = new Line();
                line.Stroke = Brushes.White;

                
                line.X1 = currentPoint.X;
                line.Y1 = currentPoint.Y;
                line.X2 = e.GetPosition(this).X;
                line.Y2 = e.GetPosition(this).Y;

                currentPoint = e.GetPosition(this);

                paintSurface.Children.Add(line);
            }
        }
    }
}

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
using System.Windows.Shapes;

namespace Kladionica
{
    /// <summary>
    /// Interaction logic for RadnikPocetna.xaml
    /// </summary>
    public partial class RadnikPocetna : Window
    {
        private Radnica r;

        public RadnikPocetna(Radnica r)
        {
            InitializeComponent();
            this.Title = "Kladionica d.o.o.";
            this.Top = 0;
            this.Left = 0;
            izlogovan = false;

            Stranica.Content = new Welcome();
            this.r = r;
        }

        private void BPrintaj_Click(object sender, RoutedEventArgs e)
        {
            
            Ponuda p = BazaPodataka.DAL.Factory.getPonudaDAO().getByExample(new DateTime(2014,6,6));
            
            PonudeRadnikMeni pregled = new PonudeRadnikMeni();
            
            Stranica.Content = pregled;
           
        }

        private void BPrintaj_Click1(object sender, RoutedEventArgs e)
        {
            BazaPodataka.IgraDAO dao = BazaPodataka.DAL.Factory.getIgraDao();

            Ponuda p = BazaPodataka.DAL.Factory.getPonudaDAO().getByExample(DateTime.Now);
            if (p == null)
            {
                p = new Ponuda(DateTime.Now);
                p.ID = Convert.ToInt32(BazaPodataka.DAL.Factory.getPonudaDAO().create(p));
            };

            Tenis t = new Tenis(new DateTime(2014, 6, 12, 17, 30, 0), "London(M)", StatusIgre.NijePocela, "Lajovic D." , "Lopez F.");
            t.dodajKoeficijent(new Koeficijent("1",4.70M));
            t.dodajKoeficijent(new Koeficijent("2",1.20M));

            foreach (var item in t.koeficijenti)
            {
                MessageBox.Show(item.tip + item.koeficijent);
            }
            dao.create(t,p);

            t = new Tenis(new DateTime(2014, 6, 12, 17, 30, 0), "London(M)", StatusIgre.NijePocela, "Brown D.", "Kuznetsov An");
            t.dodajKoeficijent(new Koeficijent("1",1.70M));
            t.dodajKoeficijent(new Koeficijent("2",2.00M));

            dao.create(t,p);

            t = new Tenis(new DateTime(2014, 6, 12, 14, 40, 0), "Halle(M)", StatusIgre.NijePocela, "Stakhovsky S.", "Brands D.");
            t.dodajKoeficijent(new Koeficijent("1", 1.70M));
            t.dodajKoeficijent(new Koeficijent("2", 2.00M));

            dao.create(t, p);

            FudbalskaUtakmica f = new FudbalskaUtakmica(new DateTime(2014, 6, 12, 20, 00, 0), "Derbi", StatusIgre.NijePocela, "NK Vite", "NK Rijeka");
            f.koeficijenti.AddRange(new Koeficijent[] { new Koeficijent("1", 1.1M), new Koeficijent("1x",1.01M),
                                    new Koeficijent("x",2.1M), new Koeficijent("2x", 1.6M), new Koeficijent("2",3.0M)});
            
            dao.create(f, p);

            f = new FudbalskaUtakmica(new DateTime(2014, 6, 12, 21, 00, 0), "Finale", StatusIgre.NijePocela, "Hrvatska", "Bosna");
            f.koeficijenti.AddRange(new Koeficijent[] { new Koeficijent("1", 1.33M), new Koeficijent("1x",1.2M),
                                    new Koeficijent("x",1.5M), new Koeficijent("2x", 1.35M), new Koeficijent("2",2.0M)});

            dao.create(f, p);

            f = new FudbalskaUtakmica(new DateTime(2014, 6, 12, 22, 30, 0), "Derbi", StatusIgre.NijePocela, "Celik", "Zeljo");
            f.koeficijenti.AddRange(new Koeficijent[] { new Koeficijent("1", 1.2M), new Koeficijent("1x",1.15M),
                                    new Koeficijent("x",1.7M), new Koeficijent("2x", 1.5M), new Koeficijent("2",2.3M)});

            dao.create(f, p);

            

           }

        private void BKlubKorisnika_Click(object sender, RoutedEventArgs e)
        {
            RegistrujKorisnika r = new RegistrujKorisnika(Stranica);
            r.Show();
        }

        private void BNoviTiket_Click(object sender, RoutedEventArgs e)
        {
            Stranica.Content = new NoviTiket.NoviTiketMeni();
        }
        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            Stranica.Content = new UnosKorisnika(Stranica);
        }

        private void BLock_Click(object sender, RoutedEventArgs e)
        {
            Dizajn.LOCK novi = new Dizajn.LOCK(r);

            izlogovan = true;

            App.Current.MainWindow = novi;
            this.Close();
            novi.Show();
        }

        private void BLogOut_Click(object sender, RoutedEventArgs e)
        {
            
            BazaPodataka.DAL.Connection.Open();
            string cmd = String.Format("insert into odlazaksposla values ('{0}', '{1}')", r.ID, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            MySqlCommand c = new MySqlCommand(cmd, BazaPodataka.DAL.Connection);
            c.ExecuteNonQuery();
            BazaPodataka.DAL.Connection.Close();
            izlogovan = true;

            Window novi = new MainWindow();
            App.Current.MainWindow = novi;
            this.Close();
            novi.Show();

        }

        private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!izlogovan)
            {
                BazaPodataka.DAL.Connection.Open();
                string cmd = String.Format("insert into odlazaksposla values ('{0}', '{1}')", r.ID, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                MySqlCommand c = new MySqlCommand(cmd, BazaPodataka.DAL.Connection);
                c.ExecuteNonQuery();
                BazaPodataka.DAL.Connection.Close();
            }
        }

        public bool izlogovan { get; set; }
    }
}

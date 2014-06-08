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

            Stranica.Content = new Welcome();
            this.r = r;
        }

        private void BPrintaj_Click(object sender, RoutedEventArgs e)
        {
            
            Ponuda p = BazaPodataka.DAL.Factory.getPonudaDAO().getByExample(new DateTime(2014,6,6));
            
            PregledPonuda pregled = new PregledPonuda(p);
            
            Stranica.Content = pregled;
            
            
            
           
        }

        private void BPrintaj_Click1(object sender, RoutedEventArgs e)
        {
            BazaPodataka.IgraDAO dao = BazaPodataka.DAL.Factory.getIgraDao();

            FudbalskaUtakmica f = new FudbalskaUtakmica(new DateTime(2014, 6, 7, 20, 00, 0), "Derbi", StatusIgre.NijePocela, "NK Dinamo", "NK Hajduk");
            f.koeficijenti.AddRange(new Koeficijent[] { new Koeficijent("1", 1.1M), new Koeficijent("1x",1.01M),
                                    new Koeficijent("x",2.1M), new Koeficijent("2x", 1.6M), new Koeficijent("2",3.0M)});
            
            dao.create(f);

            f = new FudbalskaUtakmica(new DateTime(2014, 6, 7, 20, 00, 0), "Finale", StatusIgre.NijePocela, "Hrvatska", "Australija");
            f.koeficijenti.AddRange(new Koeficijent[] { new Koeficijent("1", 1.33M), new Koeficijent("1x",1.2M),
                                    new Koeficijent("x",1.5M), new Koeficijent("2x", 1.35M), new Koeficijent("2",2.0M)});

            dao.create(f);

            f = new FudbalskaUtakmica(new DateTime(2014, 6, 7, 20, 00, 0), "Derbi", StatusIgre.NijePocela, "Bosna", "Kina");
            f.koeficijenti.AddRange(new Koeficijent[] { new Koeficijent("1", 1.2M), new Koeficijent("1x",1.15M),
                                    new Koeficijent("x",1.7M), new Koeficijent("2x", 1.5M), new Koeficijent("2",2.3M)});

            dao.create(f);

           }

        private void BKlubKorisnika_Click(object sender, RoutedEventArgs e)
        {
            Stranica.Content = new AfterBKorisKlubClick(Stranica);
        }
    }
}

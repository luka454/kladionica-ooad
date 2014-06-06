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
            BazaPodataka.PonudaDAO p = BazaPodataka.DAL.Factory.getPonudaDAO();

            TextBox b = new TextBox();
            List<Ponuda> po = p.getAll();

            Stranica.Content = b;

            b.Text = String.Empty;

            foreach (var item in po)
            {
                b.Text += String.Format("{0} - {1} {2}", item.ID, item.Datum.ToString("yyyy-MM-dd"), Environment.NewLine);
            }
           
        }
    }
}

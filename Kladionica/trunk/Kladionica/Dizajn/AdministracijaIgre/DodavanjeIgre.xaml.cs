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
using Kladionica.BazaPodataka;

namespace Kladionica.AdministracijaIgre
{
    /// <summary>
    /// Interaction logic for DodavanjeIgre.xaml
    /// </summary>
    public partial class DodavanjeIgre : Window
    {
        private ContentPresenter _c;
        public DodavanjeIgre()
        {
            InitializeComponent();
        }
        public DodavanjeIgre(ContentPresenter c)
        {
            InitializeComponent();
            _c = c;
        }

        private void OdustaniF_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OdustaniT_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DodajFudbal_Click(object sender, RoutedEventArgs e)
        {
            Decimal broj1, broj1x, brojx, brojx2, broj2;
            Decimal.TryParse(k1Box.Text, out broj1);
            Decimal.TryParse(k1xBox.Text, out broj1x);
            Decimal.TryParse(kxBox.Text, out brojx);
            Decimal.TryParse(kx2Box.Text, out brojx2);
            Decimal.TryParse(k2Box.Text, out broj2);
            Koeficijent k1 = new Koeficijent("1", broj1);
            Koeficijent k1x = new Koeficijent("1x", broj1x);
            Koeficijent kx = new Koeficijent("x", brojx);
            Koeficijent kx2 = new Koeficijent("x2", brojx2);
            Koeficijent k2 = new Koeficijent("2", broj2);

            StatusIgre si=new StatusIgre();
            switch(Convert.ToString(FStatusIgre.SelectedValue))
            {
                case "Nije pocela":
                    si=StatusIgre.NijePocela;
                    break;
                case "Obustavljena":
                    si=StatusIgre.Obustavljena;
                    break;
                case "Odgodjena":
                    si=StatusIgre.Odgodjena;
                    break;
                case "U toku":
                    si=StatusIgre.UToku;
                    break;
                case "Zavrsena":
                    si=StatusIgre.Zavrsena;
                    break;
            }
            if (validirano())
            {
                FudbalskaUtakmicaDAO fudbalDAO = BazaPodataka.DAL.Factory.getFudbalskaUtakmicaDao();
                FudbalskaUtakmica f = new FudbalskaUtakmica(PocetakFDate.SelectedDate.Value, NazivFBox.Text, si, DomacinBox.Text, GostBox.Text);
                f.koeficijenti = new List<Koeficijent>() { k1, k1x, kx, kx2, k2 };

                Ponuda p = BazaPodataka.DAL.Factory.getPonudaDAO().getByExample(PocetakFDate.SelectedDate.Value);
                if (p == null)
                {
                    p = new Ponuda(PocetakFDate.SelectedDate.Value);
                    p.ID  = Convert.ToInt32(BazaPodataka.DAL.Factory.getPonudaDAO().create(p));
                }

                fudbalDAO.create(f, p);
                _c.Content = new DobarUnosIgre();
                this.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Greska prilikom unosa parametara! Unesite ponovo.");
                //_c.Content = new UnosKorisnika(_c);

            }   
        }

        private bool validirano()
        {
            if (NazivFBox.Text.Length < 2) return false;
            if (DomacinBox.Text.Length < 2) return false;
            if (GostBox.Text.Length < 2) return false;
            //if (FStatusIgre.SelectedValue == null) return false;
            return true;
        }

        private void k1Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Decimal broj1, broj2;
            Decimal.TryParse(P1Box.Text, out broj1);
            Decimal.TryParse(P2Box.Text, out broj2);
            Koeficijent P1 = new Koeficijent("1", broj1);
            Koeficijent P2 = new Koeficijent("2", broj2);

            StatusIgre si = new StatusIgre();
            switch (Convert.ToString(FStatusIgre.SelectedValue))
            {
                case "Nije pocela":
                    si = StatusIgre.NijePocela;
                    break;
                case "Obustavljena":
                    si = StatusIgre.Obustavljena;
                    break;
                case "Odgodjena":
                    si = StatusIgre.Odgodjena;
                    break;
                case "U toku":
                    si = StatusIgre.UToku;
                    break;
                case "Zavrsena":
                    si = StatusIgre.Zavrsena;
                    break;
            }
            if (validirano())
            {
                TenisDAO tenDAO = BazaPodataka.DAL.Factory.getTenisDao();
                Tenis t = new Tenis(PocetakFDate.SelectedDate.Value, NazivFBox.Text, si, PrviProtivnikBox.Text, DrugiProtivnikBox.Text);
                t.koeficijenti = new List<Koeficijent>() { P1, P2 };

                Ponuda p = BazaPodataka.DAL.Factory.getPonudaDAO().getByExample(PocetakFDate.SelectedDate.Value);
                if (p == null)
                {
                    p = new Ponuda(PocetakFDate.SelectedDate.Value);
                    p.ID = Convert.ToInt32(BazaPodataka.DAL.Factory.getPonudaDAO().create(p));
                }

                tenDAO.create(t, p);
                _c.Content = new DobarUnosIgre();
                this.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Greska prilikom unosa parametara! Unesite ponovo.");
                //_c.Content = new UnosKorisnika(_c);

            }   
        }
    }
}

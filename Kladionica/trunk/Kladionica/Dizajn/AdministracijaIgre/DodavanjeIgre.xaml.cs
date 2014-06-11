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
                fudbalDAO.create(new FudbalskaUtakmica(PocetakFDate.SelectedDate.Value, NazivFBox.Text, si, DomacinBox.Text, GostBox.Text));
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
    }
}

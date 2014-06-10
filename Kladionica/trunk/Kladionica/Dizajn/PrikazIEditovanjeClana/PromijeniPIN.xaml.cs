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
    /// Interaction logic for PromijeniPIN.xaml
    /// </summary>
    public partial class PromijeniPIN : ContentControl
    {
        public PromijeniPIN()
        {
            InitializeComponent();
        }

        ClanKluba ck;
        ContentPresenter cp;
        public PromijeniPIN(ClanKluba _ck, ContentPresenter _cp)
        {
            InitializeComponent();
            ck = _ck;
            cp = _cp;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cp.Content = new PrikazKorisnika(ck, cp);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            if (ck.PIN != Convert.ToInt32(OldPIN.Password))
            {
                System.Windows.MessageBox.Show("Pogresan stari PIN! Unesite ponovo.");
                NewPIN.Password = "";
                OldPIN.Password = "";
            }
            else
            {
                ck.PIN = Convert.ToInt32(NewPIN.Password);
                ClanKlubaDAO baza = BazaPodataka.DAL.Factory.getClanKlubaDao();
                ClanKluba c = baza.UpdatePIN(ck);
                cp.Content = new DobarUnos("PIN uspijesno promijenjen.");
                TheEnclosingMethod();
            }
        }

        public async void TheEnclosingMethod()
        {

            await Task.Delay(2000);
            cp.Content = new PrikazKorisnika(ck, cp);
        }
    }
}

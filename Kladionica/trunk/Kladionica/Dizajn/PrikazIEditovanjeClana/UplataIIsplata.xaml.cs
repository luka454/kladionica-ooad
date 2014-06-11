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
using System.Windows.Shapes;

namespace Kladionica
{
    /// <summary>
    /// Interaction logic for UplataIIsplata.xaml
    /// </summary>
    public partial class UplataIIsplata : Window
    {
        public UplataIIsplata()
        {
            InitializeComponent();
        }
        ClanKluba _c;
        string ui;
        ContentPresenter _p;
        public UplataIIsplata(string p, ClanKluba c, ContentPresenter cp)
        {
            InitializeComponent();
            this.Title = p;
            _c = c;
            UplatiIsplati.Content = p;
            ui = p;
            _p = cp;
        }

        private void UplatiIsplati_Click(object sender, RoutedEventArgs e)
        {
            if(Novac.Text.Length > 0)
            if(UnosKorisnika.IsNotAllDigit(Novac.Text)) 
            {
                System.Windows.MessageBox.Show("Ponovite unos!");
                Novac.Text = "";
            }
            else
            {
                if(ui == "Uplata")
                {
                    ClanKlubaDAO baza = BazaPodataka.DAL.Factory.getClanKlubaDao();
                    if (baza.UpdateStanjeRacuna(_c.ID, _c.Novac + Convert.ToDecimal(Novac.Text)))
                    {
                        TransakcijaDAO tra = BazaPodataka.DAL.Factory.getTransakcijaDAO();
                        tra.create(new Transakcija(Convert.ToDecimal(Novac.Text), _c));
                        _c.Novac += Convert.ToDecimal(Novac.Text);
                        _p.Content = new PrikazKorisnika(_c, _p);
                        this.Close();
                    }
                }
                else
                {
                    if(_c.Novac - Convert.ToDecimal(Novac.Text) < 0){
                        System.Windows.MessageBox.Show("Nemoguće izvrsiti isplatu!");
                        Novac.Text = "";
                    }
                    else { 
                        ClanKlubaDAO baza = BazaPodataka.DAL.Factory.getClanKlubaDao();
                        if(baza.UpdateStanjeRacuna(_c.ID, _c.Novac - Convert.ToDecimal(Novac.Text)))
                        {
                            TransakcijaDAO tra = BazaPodataka.DAL.Factory.getTransakcijaDAO();
                            tra.create(new Transakcija(-Convert.ToDecimal(Novac.Text), _c));
                            _c.Novac -= Convert.ToDecimal(Novac.Text);
                            _p.Content = new PrikazKorisnika(_c, _p);
                            this.Close();
                        }
                            
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace Kladionica.NoviTiket
{
    /// <summary>
    /// Interaction logic for UnosNovogTiketa.xaml
    /// </summary>
    public partial class UnosNovogTiketa : ListBoxItem
    {
        ListBox _owner;
        Igra igra;
        NoviTiketMeni _meni;
        public UnosNovogTiketa(ListBox owner, NoviTiketMeni meni)
        {
            _owner = owner;
            _meni = meni;
            InitializeComponent();

            IMGerr.Visibility = System.Windows.Visibility.Hidden;
        }

        private void TBID_LostFocus(object sender, RoutedEventArgs e)
        {
            int ID;
            if (!Int32.TryParse(TBID.Text, out ID))
            {
                Natpis.Text = "Uneseni ID mora biti broj!";
               
                return;
            }

            igra = BazaPodataka.DAL.Factory.getIgraDao().getById(ID);
            if (igra == null)
            {
                Natpis.Text = "Igra s unesenim IDem nije pronadjena!";
                
                return;
            }

            foreach (var item in _owner.Items)
            {
                if (item is UneseniTiketLBI)
                {
                    if (ID == ((UneseniTiketLBI)item)._igra.OdigranaIgra.ID)
                    {
                        Natpis.Text = "Nije moguće dva puta odigrati istu igru.";
                
                        return;
                    }

                }
            }

            if (igra.statusIgre != StatusIgre.NijePocela)
            {
                Natpis.Text = "Igra je ";
                switch (igra.statusIgre)
                {
                    case StatusIgre.Obustavljena:
                        Natpis.Text += "obustavljena!";
                        break;
                    case StatusIgre.Odgodjena:
                        Natpis.Text += "odgodjena!";
                        break;
                    case StatusIgre.UToku:
                        Natpis.Text += "u toku!";
                        break;
                    case StatusIgre.Zavrsena:
                        Natpis.Text += "zavresena!";
                        break;
                }

                
                return;
            }


            if (igra is FudbalskaUtakmica)
            {
                FudbalskaUtakmica f = (FudbalskaUtakmica)igra;
                Natpis.Text = "";
                Natpis.Text += f.ID + " - ";
                if (f.Naziv != String.Empty) Natpis.Text += f.Naziv + ": ";
                Natpis.Text += String.Format("{0} - {1}", f.Domacin, f.Gost);
            }
            else if (igra is Tenis)
            {
                Tenis t = (Tenis)igra;
                Natpis.Text = "";
                Natpis.Text += t.ID + " - ";
                if (t.Naziv != String.Empty) Natpis.Text += t.Naziv + ": ";
                Natpis.Text += String.Format("{0} - {1}", t.PrviProtivnik, t.DrugiProtivnik);
            }

            TBID.IsEnabled = false;
            TBTip.IsEnabled = true;
            TBTip.Focusable = true;

            ParameterizedThreadStart ts = new ParameterizedThreadStart(dajFokus);
            Thread th = new Thread(ts);

            th.Start(TBTip);
        }

        void dajFokus(object forFocus)
        {
            UIElement e = forFocus as UIElement;
            this.Dispatcher.Invoke((Action)(() =>
             {
                 Thread.Sleep(200);
                 e.Focus();
              }));
            
        }

        private void TBTip_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!igra.ProvjeriTip(TBTip.Text))
            {
                IMGerr.Visibility = System.Windows.Visibility.Visible;
                TekstGreska.Text = "Uneseni tip nije ispravan.";

               
                return;
            }

            IMGerr.Visibility = System.Windows.Visibility.Hidden;

            TBTip.IsEnabled = false;
            BDodaj.IsEnabled = true;
            BDodaj.Focusable = true;

            Thread th = new Thread(dajFokus);
            th.Start(BDodaj);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _owner.Items.Remove(this);
            _owner.Items.Add(new UnosNovogTiketa(_owner, _meni));
               
        }

        private void BDodaj_Click(object sender, RoutedEventArgs e)
        {
            StavkaTiketa s = new StavkaTiketa(TBTip.Text, igra);
            _owner.Items.Remove(this);
            _meni.dodajStavku(s);

            UnosNovogTiketa u = new UnosNovogTiketa(_owner, _meni);
            _owner.Items.Add(u);
           
            (new Thread(dajFokus)).Start(u.TBID);
        }

        private void TBID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                int ID;
                if (!Int32.TryParse(TBID.Text, out ID))
                {
                    Natpis.Text = "Uneseni ID mora biti broj!";
                    (new Thread(dajFokus)).Start(TBID);
                    return;
                }

                igra = BazaPodataka.DAL.Factory.getIgraDao().getById(ID);
                if (igra == null)
                {
                    Natpis.Text = "Igra s unesenim IDem nije pronadjena!";
                    (new Thread(dajFokus)).Start(TBID);
                    return;
                }

                foreach (var item in _owner.Items)
                {
                    if (item is UneseniTiketLBI)
                    {
                        if (ID == ((UneseniTiketLBI)item)._igra.OdigranaIgra.ID)
                        {
                            Natpis.Text = "Nije moguće dva puta odigrati istu igru.";
                            (new Thread(dajFokus)).Start(TBID);
                            return;
                        }

                    }
                }

                if (igra.statusIgre != StatusIgre.NijePocela)
                {
                    Natpis.Text = "Igra je ";
                    switch (igra.statusIgre)
                    {
                        case StatusIgre.Obustavljena:
                            Natpis.Text += "obustavljena!";
                            break;
                        case StatusIgre.Odgodjena:
                            Natpis.Text += "odgodjena!";
                            break;
                        case StatusIgre.UToku:
                            Natpis.Text += "u toku!";
                            break;
                        case StatusIgre.Zavrsena:
                            Natpis.Text += "zavresena!";
                            break;
                    }

                    (new Thread(dajFokus)).Start(TBID);
                    return;
                }


                if (igra is FudbalskaUtakmica)
                {
                    FudbalskaUtakmica f = (FudbalskaUtakmica)igra;
                    Natpis.Text = "";
                    Natpis.Text += f.ID + " - ";
                    if (f.Naziv != String.Empty) Natpis.Text += f.Naziv + ": ";
                    Natpis.Text += String.Format("{0} - {1}", f.Domacin, f.Gost);
                }
                else if (igra is Tenis)
                {
                    Tenis t = (Tenis)igra;
                    Natpis.Text = "";
                    Natpis.Text += t.ID + " - ";
                    if (t.Naziv != String.Empty) Natpis.Text += t.Naziv + ": ";
                    Natpis.Text += String.Format("{0} - {1}", t.PrviProtivnik, t.DrugiProtivnik);
                }

                TBID.IsEnabled = false;
                TBTip.IsEnabled = true;
                TBTip.Focusable = true;

                ParameterizedThreadStart ts = new ParameterizedThreadStart(dajFokus);
                Thread th = new Thread(ts);

                th.Start(TBTip);

            }
        }

        private void TBTip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                if (!igra.ProvjeriTip(TBTip.Text))
                {
                    IMGerr.Visibility = System.Windows.Visibility.Visible;
                    TekstGreska.Text = "Uneseni tip nije ispravan.";

                    Thread t = new Thread(dajFokus);
                    t.Start(TBTip);

                    return;
                }

                IMGerr.Visibility = System.Windows.Visibility.Hidden;

                TBTip.IsEnabled = false;
                BDodaj.IsEnabled = true;
                BDodaj.Focusable = true;

                Thread th = new Thread(dajFokus);
                th.Start(BDodaj);
            }
        }
    }
}

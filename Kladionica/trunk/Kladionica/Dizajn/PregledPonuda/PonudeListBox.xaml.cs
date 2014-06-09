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

namespace Kladionica.Dizajn.PregledPonuda
{
    /// <summary>
    /// Interaction logic for PonudeListBox.xaml
    /// </summary>
    public partial class PonudeListBox : ContentControl
    {
        PonudeRadnikMeni _otac;
        public PonudeListBox(PonudeRadnikMeni otac)
        {
            _otac = otac;
            InitializeComponent();

            List<Ponuda> p = BazaPodataka.DAL.Factory.getPonudaDAO().getAllWithoutGames();
            p.Sort((Ponuda p1, Ponuda p2) =>p2.Datum.CompareTo(p1.Datum));
            ponudeList.ItemsSource = p;
            
        }

        private void ponudeList_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            Ponuda p = ponudeList.SelectedItem as Ponuda;
            p.IgreUPonudi = BazaPodataka.DAL.Factory.getIgraDao().getByPonuda(p);
            _otac.Presenter.Content = new Kladionica.PregledPonuda(p);
            _otac.toolbar.Visibility = System.Windows.Visibility.Visible;
            _otac._ponuda = p;
        }
    }
}

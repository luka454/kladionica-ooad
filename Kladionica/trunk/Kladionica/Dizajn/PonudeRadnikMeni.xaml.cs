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
    /// Interaction logic for PonudeRadnikMeni.xaml
    /// </summary>
    public partial class PonudeRadnikMeni : ContentControl
    {
        public Ponuda _ponuda;
        public PonudeRadnikMeni()
        {
            InitializeComponent();
            toolbar.Visibility = System.Windows.Visibility.Collapsed;
            Presenter.Content = new Dizajn.PregledPonuda.PonudeListBox(this);
            _ponuda = null;
        }

        private void ListaPonuda_Click(object sender, RoutedEventArgs e)
        {
            toolbar.Visibility = System.Windows.Visibility.Collapsed;
            
            Presenter.Content = new Dizajn.PregledPonuda.PonudeListBox(this);
            _ponuda = null;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ponuda p = _ponuda;
            Presenter.Content = new Kladionica.PregledPonuda(p, TBtrazilica.Text);
            toolbar.Visibility = System.Windows.Visibility.Visible;
            
        }

        private void PrnBtn_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog print = new PrintDialog();
            if(print.ShowDialog() == true)
            {
                PregledPonuda p = new Kladionica.PregledPonuda(_ponuda);
                p.borderFU.Background = Brushes.White;
                p.borderT.Background = Brushes.White;
                print.PrintVisual(p, "Printanje ponude");
            }
        }
    }
}

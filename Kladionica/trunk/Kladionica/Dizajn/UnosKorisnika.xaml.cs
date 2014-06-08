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
    /// Interaction logic for UnosKorisnika.xaml
    /// </summary>
    public partial class UnosKorisnika : ContentControl
    {
        private ContentPresenter _c;
        public UnosKorisnika()
        {
            InitializeComponent();
        }

        public UnosKorisnika(ContentPresenter c)
        {
            _c = c;
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _c.Content = new AfterBKorisKlubClick(_c);
        }

        private void PassCheckBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password != PassCheckBox.Password) { }

        }
    }
}

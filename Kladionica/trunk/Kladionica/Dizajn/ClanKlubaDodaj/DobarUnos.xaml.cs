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
    /// Interaction logic for AfterBKorisKlubClick.xaml
    /// </summary>
    public partial class DobarUnos : ContentControl
    {
        public DobarUnos()
        {
            InitializeComponent();
        }
        private ContentPresenter _c;
        public DobarUnos(ContentPresenter c)
        {
            InitializeComponent();
            _c = c;
        }
        public DobarUnos(string mrak)
        {
            InitializeComponent();
            Tekst.Text = mrak;
        }
    }
}

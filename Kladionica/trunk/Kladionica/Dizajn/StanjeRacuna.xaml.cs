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
    /// Interaction logic for StanjeRacuna.xaml
    /// </summary>
    public partial class StanjeRacuna : ContentControl
    {
        public StanjeRacuna()
        {
            InitializeComponent();
        }
        ContentPresenter _c;
        public StanjeRacuna(ContentPresenter c)
        {
            InitializeComponent();
            _c = c;
        }
    }
}

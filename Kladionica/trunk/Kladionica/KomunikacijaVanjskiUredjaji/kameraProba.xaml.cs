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
using WebcamControl;

namespace Kladionica.KomunikacijaVanjskiUredjaji
{
    /// <summary>
    /// Interaction logic for kameraProba.xaml
    /// </summary>
    public partial class kameraProba : Window
    {
        Webcam w;
        public kameraProba()
        {
            w = new Webcam();
            w.
            InitializeComponent();
        }
    }
}

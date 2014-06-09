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

namespace Bingo
{
    /// <summary>
    /// Interaction logic for IzvlacenjeBrojeva.xaml
    /// </summary>
    public partial class IzvlacenjeBrojeva : Window
    {
        public Igra49 TrenutnaIgra { get; set; }
        public IzvlacenjeBrojeva()
        {
            InitializeComponent();
            TrenutnaIgra = new Igra49();
            this.Title = "Bingo";
        }
    }
}

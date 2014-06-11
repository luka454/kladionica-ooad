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

namespace Kladionica.AdministracijaIgre
{
    /// <summary>
    /// Interaction logic for DodavanjeIgre.xaml
    /// </summary>
    public partial class DodavanjeIgre : ContentControl
    {
        AdministracijaWindow _otac; //ovo ako ti zatreba da mijenjaš šta... recimo da iz ovog promijeniš šta
        //šta se prikazuje na ovoj Stranica
        public DodavanjeIgre(AdministracijaWindow otac)
        {
            _otac = otac;
            InitializeComponent();
        }
    }
}

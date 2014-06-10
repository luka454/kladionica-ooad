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
    /// Interaction logic for PrikazKorisnika.xaml
    /// </summary>
    public partial class PrikazKorisnika : ContentControl
    {
        public PrikazKorisnika()
        {
            InitializeComponent();
        }

        public PrikazKorisnika(ClanKluba c)
        {
            InitializeComponent();
            Username.Content = c.Username;
            Prezime.Content = c.Prezime;
            Ime.Content = c.Ime;
            Novac.Content = c.Novac;
        }
    }
}

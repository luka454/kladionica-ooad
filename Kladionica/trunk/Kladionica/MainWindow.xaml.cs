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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Kladionica d.o.o.";
            /*
              //Ako nemate radnicu dodanu u bazu
            try
            {
                Radnica r = new Radnica("Katarina", "Velika", "radnica01", Administracija.HashPassFunkcija("radnica01"), 500M);
                BazaPodataka.DAL.Factory.getRadnicaDAO().create(r);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             */
        }
    }
}

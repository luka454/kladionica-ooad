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

namespace Kladionica.NoviTiket
{
    /// <summary>
    /// Interaction logic for NoviTiketMeni.xaml
    /// </summary>
    public partial class NoviTiketMeni : ContentControl
    {
        ClanKluba _clan;
        public NoviTiketMeni(ClanKluba clan = null)
        {
            _clan = clan;

            InitializeComponent();

            if (_clan != null) ImeKorisnika.Text = _clan.Ime + " " + _clan.Prezime;

            BazaPodataka.IgraDAO dao = BazaPodataka.DAL.Factory.getIgraDao();
            Igra[] igre = new Igra[3] { dao.getById(62), dao.getById(63), dao.getById(65) };
            StavkaTiketa[]  stavke = new StavkaTiketa[3]{new StavkaTiketa("1",igre[0]),
                                    new StavkaTiketa("2",igre[1]), new StavkaTiketa("1x",igre[2])};
            foreach (var item in stavke)
            {
                listbox.Items.Add(new UneseniTiketLBI(item));
            }

            listbox.Items.Add(new UnosNovogTiketa(listbox));

        }
    }
}

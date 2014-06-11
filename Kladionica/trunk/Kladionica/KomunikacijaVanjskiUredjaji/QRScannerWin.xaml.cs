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
using Microsoft.Expression.Encoder.Devices;
using WebcamControl;
using System.IO;
using System.Drawing.Imaging;
using ZXing;
using ZXing.QrCode;
using System.Drawing;
using ZXing.Common;

namespace Kladionica.KomunikacijaVanjskiUredjaji
{
    /// <summary>
    /// Interaction logic for QRScannerWin.xaml
    /// </summary>
    public partial class QRScannerWin : Window
    {
        public QRScannerWin()
        {
            InitializeComponent();
        }
    }
}

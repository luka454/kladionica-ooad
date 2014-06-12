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
using Kladionica;
using Kladionica.BazaPodataka;

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
            this.Closing += QRWin_Closing;
            init();
        }

        void clean()
        {
            string[] filePaths = Directory.GetFiles(imagePath);
            foreach (string filePath in filePaths)
                File.Delete(filePath);
        }

        public static byte[] ImageToByte(System.Drawing.Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public string Process(Bitmap bitmap)
        {
            try
            {
                QRCodeReader reader = new QRCodeReader();
                LuminanceSource source = new BitmapLuminanceSource(bitmap);
                var binarizer = new HybridBinarizer(source);
                var binBitmap = new BinaryBitmap(binarizer);
                return reader.decode(binBitmap).Text;
            }
            catch
            {
                return string.Empty;
            }
        }

        void QRWin_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Cam.StopCapture();
        }

        static string imagePath = Directory.GetCurrentDirectory() + @"\qrcodes";
        void init()
        {

            Binding binding_1 = new Binding("SelectedValue");
            binding_1.Source = cbox_kamere;
            Cam.SetBinding(Webcam.VideoDeviceProperty, binding_1);

            if (!Directory.Exists(imagePath))
            {
                Directory.CreateDirectory(imagePath);
            }

            Cam.ImageDirectory = imagePath;
            Cam.FrameRate = 30;
            Cam.FrameSize = new System.Drawing.Size(640, 480);

            var vidDevices = EncoderDevices.FindDevices(EncoderDeviceType.Video);
            var audDevices = EncoderDevices.FindDevices(EncoderDeviceType.Audio);
            cbox_kamere.ItemsSource = vidDevices;
            btn_generate.IsEnabled = false;
            btn_dodaj.IsEnabled = false;
            tb_ID.TextChanged += tb_ID_TextChanged;
            Cam.SnapshotFormat = ImageFormat.Png;
            cbox_tipovi.SelectedIndex = 0;
            clean();
        }

        void tb_ID_TextChanged(object sender, TextChangedEventArgs e)
        {
            enableCreate();
        }

        private void enableCreate()
        {
            if (tb_ID.Text != "")
            {
                int id = -1;
                if (Int32.TryParse(tb_ID.Text, out id) == true)
                    btn_dodaj.IsEnabled = true;
                else
                    btn_dodaj.IsEnabled = false;
            }
            else
                btn_dodaj.IsEnabled = false;
        }



        private void VideoDevicesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbox_kamere.SelectedItem != null)
                btn_generate.IsEnabled = true;
            Cam.StartCapture();
        }


        string[] getPics()
        {
            return Directory.GetFiles(imagePath, "*.png")
                                     .Select(path => System.IO.Path.GetFileName(path))
                                     .ToArray();
        }

        void fileinfo()
        {
            DirectoryInfo d = new DirectoryInfo(imagePath);
            FileInfo[] infos = d.GetFiles();
            foreach (FileInfo f in infos)
            {
                File.Move(f.FullName, "ado.jpeg");
            }
        }

        private void btn_generate_Click(object sender, RoutedEventArgs e)
        {
            Cam.TakeSnapshot();
            var pics = getPics();
            string str = pics[pics.Length - 1];
            string input = imagePath + "\\input" + (pics.Length - 1).ToString() + ".png";
            System.IO.File.Move(imagePath + "\\" + str, input);
            tb_ID.Text = Process(new Bitmap(input));
            enableCreate();

        }

        private void btn_dodaj_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ComboBoxItem cbi = (cbox_tipovi.SelectedItem as ComboBoxItem);
                /*Medij tip= dict[cbi.Content.ToString()];
                DAL.DAOFactory.OpremaDAO.get.create(new OpremaLib.Oprema(Convert.ToInt32(tb_ID.Text),tip));*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

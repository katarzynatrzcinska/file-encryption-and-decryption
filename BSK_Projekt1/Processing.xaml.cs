using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BSK_Projekt1
{
    /// <summary>
    /// Interaction logic for Processing.xaml
    /// </summary>
    public partial class Processing : Window
    {
        Boolean done = true;
        public Processing(List<string> receivers, FileInfo fileToEncrypt, System.Security.Cryptography.CipherMode mode, string outputName)
        {
            InitializeComponent();
            this.Top = 270;
            this.Left = 480;
            Encoder encoder = new Encoder(receivers, fileToEncrypt, mode, outputName);
            encoder.EncodeFile(this.progressBar);
        }

        private void CloseAllWindows()
        {
            for (int intCounter = App.Current.Windows.Count - 1; intCounter > 0; intCounter--)
                App.Current.Windows[intCounter].Close();
        }

        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {
            if (done)
            {
                MainWindow mw = new MainWindow();
                for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 0; intCounter--)
                    App.Current.Windows[intCounter].Hide();
                mw.Show();
            }
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

     
    }
}

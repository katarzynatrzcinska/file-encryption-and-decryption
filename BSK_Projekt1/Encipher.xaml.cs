
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace BSK_Projekt1
{
    /// <summary>
    /// Interaction logic for Encipher.xaml
    /// </summary>
    public partial class Encipher : Window
    {
        List<string> receivers;
        public Encipher(List<string> chosenReceivers)
        {
            InitializeComponent();
            receivers = chosenReceivers;
            this.Top = 100;
            this.Left = 350;
        }

        private void buttonNext_Click(object sender, RoutedEventArgs e)
        {
            labelErrorsNoFile.Content = "";
            labelErrorsNoName.Content = "";

            if (textBoxChosenName.Text.Length.Equals(0))
                labelErrorsNoName.Content = "Wpisz nazwę pliku wynikowego!";
            if (textBoxChosenFile.Text.Length.Equals(0))
                labelErrorsNoFile.Content = "Wybierz plik do szyfrowania!";
            else if (!textBoxChosenName.Text.Length.Equals(0) && !textBoxChosenFile.Text.Length.Equals(0))
            {
                Processing pr = new Processing();
                pr.ShowDialog();
            }
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            Receiver re = new Receiver();
            re.Show();
            this.Close();
        }

        private void buttonChooseFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            textBoxChosenFile.Text = file.SafeFileName.ToString();
         }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}

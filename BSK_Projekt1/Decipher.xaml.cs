using Microsoft.Win32;
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

namespace BSK_Projekt1
{
    /// <summary>
    /// Interaction logic for Decipher.xaml
    /// </summary>
    public partial class Decipher : Window
    {
        List<string> receivers = new List<string>();
        public Decipher()
        {
            InitializeComponent();

            this.Top = 100;
            this.Left = 350;

            receivers = new List<string>();
            receivers.Add("Użytkownik #1");
            receivers.Add("Użytkownik #2");
            receivers.Add("Użytkownik #3");

            listBox.ItemsSource = receivers;
            listBox.SelectedIndex = 0;
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void buttonDecipher_Click(object sender, RoutedEventArgs e)
        {
            labelErrorsNoFile.Content = "";
            labelErrorsNoName.Content = "";
            labelNoPassword.Content = "";
            if (textBoxChosenName.Text.Length.Equals(0))
                labelErrorsNoName.Content = "Wpisz nazwę pliku wynikowego!"; 
            if (textBoxChosenFile.Text.Length.Equals(0))
                labelErrorsNoFile.Content = "Wybierz plik do deszyfrowania!";
            if (textBoxPassword.Text.Length.Equals(0))
                labelNoPassword.Content = "Wpisz hasło!";
            if (!textBoxChosenName.Text.Length.Equals(0) && !textBoxChosenFile.Text.Length.Equals(0) && !textBoxPassword.Text.Length.Equals(0))
            {
                //Processing pr = new Processing();
                //pr.ShowDialog();
            }
        }

        private void buttonChooseFile_Click(object sender, RoutedEventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            textBoxChosenFile.Text = file.SafeFileName.ToString();
        }
        
    }
}

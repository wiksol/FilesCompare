using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace ProgramDlaOli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ZarzadaniePlikiem plik = new ZarzadaniePlikiem();

        

        public MainWindow()
        {
            InitializeComponent();
            plik.NazwaPliku3 = "PlikDlaOlenki.txt";
            
        }

        private void BtnWybierz1_Click(object sender, RoutedEventArgs e)
        {
            plik.NazwaPliku1 = WyborPliku();
            if (!(plik.NazwaPliku1 == null))
            {
                tbPlik1.Text = plik.NazwaPliku1;
            }
        }

        private void BtnWybierz2_Click(object sender, RoutedEventArgs e)
        {
            plik.NazwaPliku2 = WyborPliku();
            if (!(plik.NazwaPliku2 == null))
            {
                tbPlik2.Text = plik.NazwaPliku2;
            }
        }

        private void BtnWybierz3_Click(object sender, RoutedEventArgs e)
        {
            string folderDocelowy=null;
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                folderDocelowy = dialog.FileName;
            }
            if (!(folderDocelowy == null))
            {
                plik.NazwaPliku3 = string.Concat(folderDocelowy, "\\PlikDlaOlenki.txt");
                tbPlik3.Text = plik.NazwaPliku3;
            }
        }

        private string WyborPliku()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            Nullable<bool> dialogOK = fileDialog.ShowDialog();
            if (dialogOK == true)
            {
                return fileDialog.FileName;
            }
            return null;
        }

        private void BtnWykonaj_Click(object sender, RoutedEventArgs e)
        {
            
            if (plik.ZaczytajDane())
            {
                plik.Znajdz();
                tbStatus.Text = "Wykonano poprawnie i zapisano pod nazwą PlikDlaOlenki";
            }
            else
            {
                tbStatus.Text = "Załaduj poprawnie pliki";
            }
        }
    }
}

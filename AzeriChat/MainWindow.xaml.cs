using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace AzeriChat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     
        public MainWindow()
        {
            InitializeComponent();
        }


        private void SendBtn_Click(object sender, RoutedEventArgs e)
        {
            string spac = "\n";
           


            ListBox1.HorizontalAlignment = HorizontalAlignment.Left;
            ListBox1.Items.Add(MessageTxtBox.Text);
            ListBox1.Items.Add(spac);

            MessageTxtBox.Text = MessageTxtBox.Text.ToLower();
            if (MessageTxtBox.Text == "salam")
            {
                ListBox.HorizontalAlignment = HorizontalAlignment.Right;
                ListBox.Items.Add(spac);
                ListBox.Items.Add(IService.GetResponseForSalam());
            }
            else if (MessageTxtBox.Text == "necesen")
            {
                ListBox.HorizontalAlignment = HorizontalAlignment.Right;
                ListBox.Items.Add(spac);
                ListBox.Items.Add(IService.GetResponseForNecesen());
            }
            else if (MessageTxtBox.Text == "neyneyirsen")
            {
                ListBox.HorizontalAlignment = HorizontalAlignment.Right;
                ListBox.Items.Add(spac);
                ListBox.Items.Add(IService.GetResponseForNeyneyirsen());
            }
            else if (MessageTxtBox.Text == "hardasan")
            {

                ListBox.HorizontalAlignment = HorizontalAlignment.Right;
                ListBox.Items.Add(spac);
                ListBox.Items.Add(IService.GetResponseForHardasan());
            }
            else
            {
                ListBox.HorizontalAlignment = HorizontalAlignment.Right;
                ListBox.Items.Add(spac);
                ListBox.Items.Add(IService.GetResponseRandom());
            }
            MessageTxtBox.Text = string.Empty;



        }


        private void PinBtn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();


            Nullable<bool> result = openFileDlg.ShowDialog();

            if (result == true)
            {
                using (StringReader reader = new StringReader(openFileDlg.FileName))
                {
                    string label = reader.ReadToEnd();
                    MessageTxtBox.Text = File.ReadAllText(label);

                }
            }
        }
    }
}

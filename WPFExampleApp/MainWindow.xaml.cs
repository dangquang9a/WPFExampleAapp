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

namespace WPFExampleApp
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            String strMessage, strHoten, strTitle = "", strNgoaiNgu = "";
            strHoten = textBox1.Text + " " + textBox2.Text;

            if (radioButton1.IsChecked == true) strTitle = "Mr.";
            else if (radioButton2.IsChecked == true) strTitle = "Miss/Mr.s";

            if (checkBox1.IsChecked == true) strNgoaiNgu = "Tiếng Trung";

            if (checkBox2.IsChecked == true)
            {
                strNgoaiNgu = (strNgoaiNgu.Length == 0) ? "Tiếng Anh" : "Tiếng Trung và Tiếng Anh";
            }

            strMessage = "Xin chào " + strTitle + strHoten + "\n Ngoại ngữ " + strNgoaiNgu + "\n Quê quán " + comboBox1.Text;

            MessageBox.Show(strMessage);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.IsChecked = true;
            radioButton2.IsChecked = false;
            radioButton3.IsChecked = false;
            checkBox1.IsChecked = false;
            checkBox2.IsChecked = false;
            comboBox1.Text = "";

        }
    }
}

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

namespace PR1_CH
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a, b, s;
            try
            {
                a = Convert.ToDouble(TextBox1.Text);
                b = Convert.ToDouble(TextBox2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Отсутствует или ошибочное значение переменных!!", "Ошибка"); 
                return;
            }
            s = (a + b) / 2;
            TextBox3.Text = Math.Round(s,4).ToString();

        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

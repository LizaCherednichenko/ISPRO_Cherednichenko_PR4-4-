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

namespace ISPRO_Cherednichenko_PR4_4_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string b;
        string a;

        private void start_Click(object sender, RoutedEventArgs e)
        {
            b = TB_N.Text;
            double rand = new Random();
            a = rand.Next(0, 10).ToString();

            if (b == rand)
            {
                label1.Content ="Победа";
            }
            else if (b > rand)
            {
                label1.Content = "Меньше";
            }
            else
            {
                label1.Content = "Больше";
            }
        }
    }
}

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

        int a;
        int b;
        int rand;

        private void start_Click(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(TB_N.Text);
            

            if (a == rand)
            {
                label1.Content = "Победа";
            }
            else if (a > rand)
            {
                label1.Content = "Меньше";
            }
            else 
            {
                label1.Content = "Больше";
            }
           
        }

        private void randOK_Click(object sender, RoutedEventArgs e)
        {
            b = Int32.Parse(TB_R.Text);
            Random r = new Random();
            rand = r.Next(0, b);
        }
    }
}

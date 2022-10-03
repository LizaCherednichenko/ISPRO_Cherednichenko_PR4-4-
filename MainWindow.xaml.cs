﻿using System;
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



        private void start_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(TB_N.Text);
            int b = Int32.Parse(TB_R.Text);
            Random r = new Random();
            int rand = r.Next(0, b);

            if (a == rand)
            {
                label1.Content = "Победа";
            }
            else if (a > rand)
            {
                label1.Content = "Меньше";
            }
            else if (a < rand)
            {
                label1.Content = "Больше";
            }
            else
            {
                label1.Content = "Ошибка";
            }
        }

        private void RandOK_Click(object sender, RoutedEventArgs e)
        {
            int b = Int32.Parse(TB_R.Text);
            Random r = new Random();
            int rand = r.Next(0, b);
        }
    }
}

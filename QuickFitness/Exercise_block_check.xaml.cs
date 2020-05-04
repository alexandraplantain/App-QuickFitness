using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using QuickFitness.Models;
using System.Data.Entity;

namespace QuickFitness
{
    /// <summary>
    /// Логика взаимодействия для Exercise_block_check.xaml
    /// </summary>
    public partial class Exercise_block_check : UserControl
    {
        User user;
        public Exercise_block_check()
        {
            InitializeComponent();
        }

        int time;
        string name;
        string groupe;
        bool flag = true;

        public void Sends(int t, string s, string g)
        {
            time = t;
            groupe = g;
            name = s;
        }

        private void Button_Check_Click(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                this.Button_Check.Background = new SolidColorBrush(Color.FromRgb(112, 112, 112));
                flag = false;
            }
            else
            {
                this.Button_Check.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
                flag = true;
            }
        }

        private void Button_Check_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}

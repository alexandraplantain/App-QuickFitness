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
    /// Логика взаимодействия для Create_train.xaml
    /// </summary>
    public partial class Create_train : Page
    {
        User user;
        public Create_train(User us)
        {
            user = us;
            InitializeComponent();

           var panel = new StackPanel();
            for (int i = 0; i < 7; i++)
            {
               var a = new Exercise_block_check();
                panel.Children.Add(a);

            }
           this.List_train.Content = panel;
        }

        private void Button_first_Click(object sender, RoutedEventArgs e)
        {
            this.Button_first.Background = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            this.Button_first.Foreground = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            this.Button_second.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_second.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            this.Button_third.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_third.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            this.Button_four.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_four.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

        }

        private void Button_second_Click(object sender, RoutedEventArgs e)
        {
            this.Button_first.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_first.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Button_second.Background = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            this.Button_second.Foreground = new SolidColorBrush(Color.FromRgb(254, 95, 27));

            this.Button_third.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_third.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Button_four.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_four.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));
        }

        private void Button_third_Click(object sender, RoutedEventArgs e)
        {
            this.Button_first.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_first.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Button_second.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_second.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Button_third.Background = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            this.Button_third.Foreground = new SolidColorBrush(Color.FromRgb(254, 95, 27));

            this.Button_four.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_four.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));
        }

        private void Button_four_Click(object sender, RoutedEventArgs e)
        {
            this.Button_first.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_first.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Button_second.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_second.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Button_third.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_third.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Button_four.Background = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            this.Button_four.Foreground = new SolidColorBrush(Color.FromRgb(254, 95, 27));
        }

        

        
        private void Button_intens_one_Click(object sender, RoutedEventArgs e)
        {
            this.Button_intens_one.Background = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            this.Button_intens_two.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_intens_three.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
        }

        private void Button_intens_two_Click(object sender, RoutedEventArgs e)
        {
            this.Button_intens_one.Background = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            this.Button_intens_two.Background = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            this.Button_intens_three.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
        }

        private void Button_intens_three_Click(object sender, RoutedEventArgs e)
        {
            this.Button_intens_one.Background = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            this.Button_intens_two.Background = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            this.Button_intens_three.Background = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            
        }
    }
}

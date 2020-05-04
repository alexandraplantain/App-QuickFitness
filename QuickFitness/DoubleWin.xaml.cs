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
using System.Windows.Shapes;
using QuickFitness.Models;
using System.Data.Entity;

namespace QuickFitness
{
    /// <summary>
    /// Логика взаимодействия для DoubleWin.xaml
    /// </summary>
    public partial class DoubleWin : Window
    {
        User user;
        int choose_win=1;
        public DoubleWin(User us)
        {
            user = us;
            InitializeComponent();

           
        }
        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        public void Choose_frame(int i)

        {
            if (choose_win == i)
            {
                this.Main_Frame.Navigate(new Create_train(user, this));
            }
            else
            {
                this.Main_Frame.Navigate(new ExerciseInformation());
            }
        }


        private void Button_go_to_all_train (object sender, RoutedEventArgs e)
        {
            var win = new MainTrainWin(user);
            win.Show();
            this.Close();
        }
    }
}

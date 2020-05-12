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
    /// Логика взаимодействия для ANNOUNCEMENTWorkoutFinale.xaml
    /// </summary>
    public partial class ANNOUNCEMENTNoWorkoutsCreated : Window
    {
        User user;
        public ANNOUNCEMENTNoWorkoutsCreated(User us)
        {
            InitializeComponent();
            user = us;
        }

        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            this.Close();         
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        MainTrainWin main_tr;
       
        public void Object_sends(MainTrainWin e)
        {
             main_tr = e;           
        }

        private void Button_create_train(object sender, RoutedEventArgs e)
        {
            var win = new DoubleWin(user);
            win.Choose_frame(1);
            win.Show();
            main_tr.Close();
            this.Close();
        }
    }
}

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
    /// Логика взаимодействия для ANNOUNCEMENTNoWorkoutsCreated.xaml
    /// </summary>
    public partial class ANNOUNCEMENTWorkoutFinale : Window
    {
        public ANNOUNCEMENTWorkoutFinale()
        {
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
    }
}

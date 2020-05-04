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

namespace QuickFitness
{
    /// <summary>
    /// Логика взаимодействия для ERRORWin.xaml
    /// </summary>
    public partial class ERRORWin : Window
    {

        public ERRORWin()
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

       public void ChooseError(string s)
        {
            switch (s)
            {
                case "ERRORDataEntry":
                    this.ERRORDataEntry.Visibility = Visibility.Visible;
                    break;
                case "ERRORLoginClose":
                    this.ERRORLoginClose.Visibility = Visibility.Visible;
                    break;
                case "ERRORWrongPassword":
                    this.ERRORWrongPassword.Visibility = Visibility.Visible;
                    break;
            }
        }
    }
}

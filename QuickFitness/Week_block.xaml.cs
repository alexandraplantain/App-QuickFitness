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

namespace QuickFitness
{
    /// <summary>
    /// Логика взаимодействия для Week_block.xaml
    /// </summary>
    public partial class Week_block : UserControl
    {

        int k;
        string s;

        public void Send_kol(int kol)
        {
            k = kol;
            Fill_week();
        }

        private void Fill_week()
        {
            k = (k * 2) - 1;
            for (int i = 1; i <= k; i++)
            {
                s = "El" + i;
                switch (s)
                {
                    case "El1":
                        this.El1.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                        break;
                    case "El2":
                        this.El2.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                        break;
                    case "El3":
                        this.El3.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                        break;
                    case "El4":
                        this.El4.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                        break;
                    case "El5":
                        this.El5.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                        break;
                    case "El6":
                        this.El6.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                        break;
                    case "El7":
                        this.El7.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                        break;
                    case "El8":
                        this.El8.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                        break;
                    case "El9":
                        this.El9.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                        break;
                    case "El10":
                        this.El10.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                        break;
                    case "El11":
                        this.El11.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                        break;
                    case "El12":
                        this.El12.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                        break;
                    case "El13":
                        this.El13.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                        this.El14.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                        this.Win_reward.Visibility = Visibility.Visible;
                        break;

                }

            }
        }

        public Week_block()
        {
            InitializeComponent();        
        }
    }
}

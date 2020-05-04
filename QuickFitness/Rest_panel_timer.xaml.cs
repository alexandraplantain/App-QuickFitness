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
using System.Windows.Threading;

namespace QuickFitness
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Rest_panel_timer : Page
    {
        public Rest_panel_timer()
        {
            InitializeComponent();
        }
        DispatcherTimer dt;
        int p = 0;
        bool k = true;
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Time_go();
        }

        public void Time_go()
        {
            if (p < 4)
            {
                dt = new DispatcherTimer();
                dt.Interval = TimeSpan.FromSeconds(1);
                dt.Tick += dtTicker;
                dt.Start();

                p++;
            }
        }

        int increment = 0;
        private void dtTicker(object sender, EventArgs e)
        {
            increment++;

            if (increment > 6)
            {

                dt.Stop();
                increment = 0;
                Time_go();
                
               

            }
            else
            {


                this.Timer_rest.Text = (6 - increment).ToString();

            }


        }
    }
}

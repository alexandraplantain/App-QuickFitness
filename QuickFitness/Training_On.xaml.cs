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
using System.Windows.Threading;
using QuickFitness.Models;
using System.Data.Entity;

namespace QuickFitness
{
    /// <summary>
    /// Логика взаимодействия для Training_On.xaml
    /// </summary>
    public partial class Training_On : Window
    {
        Exercise [] array_ex;
        Training train;
        User user;
        int kol;//общее кол-во итераций то есть и упр и отдых
        public Training_On(User us, Training tr, Exercise[] array, int i)
        {
            InitializeComponent();
            train = tr;
            array_ex = array;
            user = us;
            kol = i;
        }

        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        bool flag0 = true;

        private void Button_stop_time(object sender, RoutedEventArgs e)
        {
            if (flag0)
            {
                dt.Stop();
                flag0 = false;
                this.Stop_time.Content = "Продолжить";
            }
            else
            {
                dt.Start();
                flag0 = true;
                this.Stop_time.Content = "Остановить таймер";
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                if (flag0)
                {
                    dt.Stop();
                    flag0 = false;
                    this.Stop_time.Content = "Продолжить";
                }
                else
                {
                    dt.Start();
                    flag0 = true;
                    this.Stop_time.Content = "Остановить таймер";
                }
            }
        }


        DispatcherTimer dt;
        int p = 0;
        bool k = true;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Time_go();

        }
        int kl = 0;
        public void Time_go()
        {
            if (p < kol)
            {


                if (p % 2 == 0)
                {
                    time_ex = array_ex[kl].Time;
                    this.On_Text.Text = array_ex[kl].Decription;
                    kl++;
                }

                    dt = new DispatcherTimer();
                dt.Interval = TimeSpan.FromSeconds(1);
                dt.Tick += dtTicker;
                dt.Start();

                p++;

            }
            else
            {
                var win = new Info_train(train, user);
                win.Take_Stat();
                this.Close();
                win.Show();
            }
        }
        
        

        int increment = 0;
        
        int time_ex;
        int time_rest = 15;
        bool flag1 = false;
        bool flag2 = false;

        private void dtTicker(object sender, EventArgs e)
        {
            increment++;

            if (p % 2 == 1)
            {
                if (increment > time_ex)
                {
                    flag1 = true;
                }
            }
            else
            {
                if (increment > time_rest)
                {
                    flag2 = true;
                }
            }

            if (flag1 || flag2)
            {

                dt.Stop();
                increment = 0;
                Time_go();
                flag1 = flag2 = false;



            }
            else
            {

                if (p % 2 == 1)
                {
                    this.Do_panel.Visibility = Visibility.Visible;
                    this.Rest_panel.Visibility = Visibility.Hidden;
                    this.Timer.Text = "0:" + (time_ex - increment).ToString();
                }
                else
                {

                    this.Do_panel.Visibility = Visibility.Hidden;
                    this.Rest_panel.Visibility = Visibility.Visible;
                    this.Timer_rest.Text = "0:" + (time_rest - increment).ToString();

                }


            }


        }

        private void Back_to_info_train_Click(object sender, RoutedEventArgs e)
        {
            var win = new Info_train(train,user);
            win.Show();
            this.Close();
        }

       
    }
}

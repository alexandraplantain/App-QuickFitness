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
using System.Text.RegularExpressions;
using System.Linq;

namespace QuickFitness
{
    /// <summary>
    /// Логика взаимодействия для registr_login.xaml
    /// </summary>
    public partial class registr_login : Window
    {           
        public registr_login()
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

        public int progress_bar_step = 1;
        public bool flag = true;
        public bool flag2 = false;
        public bool flag3 = false;
        public bool flag4 = true;
        User new_user;

        private void Button_Click_Return_Regist(object sender, RoutedEventArgs e)
        {
            if (progress_bar_step == 2 || flag4)
            {
                chose_login win = new chose_login();
                win.Show();
                this.Close();
            }
            else
            {
                progress_bar_step = progress_bar_step - 2;
                Button_Click_Next_Regist(sender, e);
                flag2 = flag3 = false;
            }
        }


        private void Button_Click_Next_Regist(object sender, RoutedEventArgs e)
        {
            if (!flag2)
            {
                using (UserContext db = new UserContext())
                {
                    var user_linq = db.Users.Where(p => p.Login == this.new_login.Text).ToList();

                    if (user_linq.Count != 0)
                    {
                        var win_c = new ERRORWin();
                        win_c.ChooseError("ERRORLoginClose");
                        win_c.Show();
                    }
                    else
                    {
                        if (this.new_login.Text == "")
                        {
                            var win_a = new ERRORWin();
                            win_a.ChooseError("ERRORDataEntry");
                            win_a.Show();
                        }
                        else
                        {
                            flag2 = true;
                        }
                    }
                }
            }

            if (flag2)
            {
                Regex reg = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])\S{1,8}$");
                MatchCollection matches = reg.Matches(this.new_password.Text);
                if (matches.Count > 0)
                {
                    flag3 = true;
                }
                else
                {
                    var win_a = new ERRORWin();
                    win_a.ChooseError("ERRORDataEntry");
                    win_a.Show();
                    flag2 = false;
                }
            }

            if (flag2 && flag3)
            {
                if (flag)
                {
                    progress_bar_step++;
                    flag = false;
                }

                flag4 = false;
               
                switch (progress_bar_step)
                {

                    case 1:
                        this.Progress_bar_registr.Value = 25;
                        this.Grid__regist_1.Visibility = Visibility.Visible;
                        this.Grid_regist_2.Visibility = Visibility.Hidden;
                        this.Grid_regist_3.Visibility = Visibility.Hidden;
                        this.noti.Visibility = Visibility.Hidden;
                        progress_bar_step++;
                        break;

                    case 2:
                        this.Progress_bar_registr.Value = 50;
                        this.Grid__regist_1.Visibility = Visibility.Hidden;
                        this.Grid_regist_2.Visibility = Visibility.Visible;
                        this.Grid_regist_3.Visibility = Visibility.Hidden;
                        this.noti.Visibility = Visibility.Hidden;
                        progress_bar_step++;
                        break;

                    case 3:

                        
                        if (this.new_name.Text == "")
                        {
                            this.Progress_bar_registr.Value = 50;
                            var win_er = new ERRORWin();
                            win_er.ChooseError("ERRORDataEntry");
                            win_er.Show();                            
                        }
                        else
                        {
                            this.Progress_bar_registr.Value = 75;
                            this.Grid__regist_1.Visibility = Visibility.Hidden;
                            this.Grid_regist_2.Visibility = Visibility.Hidden;
                            this.Grid_regist_3.Visibility = Visibility.Visible;
                            this.noti.Visibility = Visibility.Hidden;
                            progress_bar_step++;
                        }                           
                        break;

                    case 4:
                        
                        Regex reg = new Regex(@"^[0-9]*[,]?[0-9]+$");
                        MatchCollection matches1 = reg.Matches(this.new_w_s.Text);
                        MatchCollection matches2 = reg.Matches(this.new_w_g.Text);
                        if (matches1.Count == 0 || matches2.Count == 0)
                        {
                            this.Progress_bar_registr.Value = 75;
                            var win_er = new ERRORWin();
                            win_er.ChooseError("ERRORDataEntry");
                            win_er.Show();
                            

                        }
                        else
                        {
                            this.Progress_bar_registr.Value = 100;
                            this.Grid__regist_1.Visibility = Visibility.Hidden;
                            this.Grid_regist_2.Visibility = Visibility.Hidden;
                            this.Grid_regist_3.Visibility = Visibility.Hidden;
                            this.noti.Visibility = Visibility.Visible;
                            progress_bar_step++;
                        }
                        
                        break;

                    case 5:
                        DateTime data = DateTime.Now;
                        using (UserContext db = new UserContext())
                        {
                            new_user = new User { ID_user = 1, Name = this.new_name.Text, Age = Convert.ToInt32(this.new_age.Text), Weight_start = this.new_w_s.Text, Weight_goal = this.new_w_g.Text, Data_start = data.ToString(), Login = this.new_login.Text, Password = this.new_password.Text };
                            db.Users.Add(new_user);
                            db.SaveChanges();
                            MainTrainWin win = new MainTrainWin(new_user);
                            win.Show();
                            this.Close();
                        }
                        break;
                }

                
            }


        }
    }
}

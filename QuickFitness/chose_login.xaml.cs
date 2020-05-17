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
using System.Linq;

namespace QuickFitness
{
    /// <summary>
    /// Логика взаимодействия для chose_login.xaml
    /// </summary>
    /// 

    public partial class chose_login : Window
    {


        public chose_login()
        {
            InitializeComponent();
        }

        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Made_new_login(object sender, RoutedEventArgs e)
        {
            registr_login regist = new registr_login();
            regist.Show();
            this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_go_Click(object sender, RoutedEventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                var user_linq = db.Users.Where(p => p.Login == this.input_login.Text).ToList();

                bool flag1 = false;
                bool flag2 = false;
                User Item = null;

                if (user_linq.Count != 0)
                {
                    flag1 = true;
                    this.Error_not_match.Visibility = Visibility.Hidden;
                }
                else
                {
                    this.Error_not_log.Visibility = Visibility.Visible;
                    this.Error_not_match.Visibility = Visibility.Hidden;
                }

                if (flag1)
                {
                    var pass_linq = db.Users.Where(p => p.Password == this.input_password.Password).ToList();

                    if (pass_linq.Count != 0)
                    {
                        flag2 = true;
                        foreach (var item in pass_linq)
                        {
                            Item = item;
                        }
                    }
                    else
                    {
                        this.Error_not_match.Visibility = Visibility.Visible;
                        this.Error_not_log.Visibility = Visibility.Hidden;
                    }
                }

                if (flag1 && flag2)
                {
                    var win_main = new MainTrainWin(Item);
                    win_main.Show();
                    db.Dispose();
                    this.Close();                    
                }
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                using (UserContext db = new UserContext())
                {                    
                    var user_linq = db.Users.Where(p => p.Login == this.input_login.Text).ToList();
                    bool flag1 = false;
                    bool flag2 = false;
                    User Item = null;

                    if (user_linq.Count != 0)
                    {
                        flag1 = true;
                        this.Error_not_match.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        this.Error_not_log.Visibility = Visibility.Visible;
                        this.Error_not_match.Visibility = Visibility.Hidden;
                    }

                    if (flag1)
                    {
                        var pass_linq = db.Users.Where(p => p.Password == this.input_password.Password).ToList();

                        if (pass_linq.Count != 0)
                        {
                            flag2 = true;
                            foreach (var item in pass_linq)
                            {
                                Item = item;
                            }
                        }
                        else
                        {
                            this.Error_not_match.Visibility = Visibility.Visible;
                            this.Error_not_log.Visibility = Visibility.Hidden;
                        }
                    }

                    if (flag1 && flag2)
                    {
                        var user = Item;
                        var win_main = new MainTrainWin(user);
                        win_main.Show();
                        db.Dispose();
                        this.Close();
                        flag1 = flag2 = false;
                    }
                }
            }
        }
    }
}



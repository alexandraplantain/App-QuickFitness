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
                db.Users.Load();
                var list = db.Users.Local.ToBindingList();
                bool flag1 = false;
                bool flag2 = false;
                foreach (var itme in list)
                {
                    if (itme.Login == this.input_login.Text)
                    {
                        flag1 = true;
                    }
                    else
                    {
                        this.Error_not_log.Visibility = Visibility.Visible;
                    }

                    if (flag1)
                    {
                        if (itme.Password == this.input_password.Password)
                        {
                            flag2 = true;
                        }
                        else
                        {
                            this.Error_not_match.Visibility = Visibility.Visible;
                        }
                    }

                    if (flag1 && flag2)
                    {
                        var user = itme;
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

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
    /// Логика взаимодействия для MainTrainWin.xaml
    /// </summary>
    public partial class MainTrainWin : Window
    {
        public User user;
        public MainTrainWin(User us)
        {
            InitializeComponent();

            user = us;

            using (UserContext db = new UserContext())
            {
                db.Users.Load();
                var list = db.Users.Local.ToBindingList();
                foreach (var itme in list)
                {
                    if (itme.Login == us.Login)
                    {
                        this.Name_user.Text = itme.Name.ToString();
                        this.Weight.Text = itme.Weight_start.ToString();
                    }
                }

            }
            All_train win_all = new All_train(user);
            this.Main_Frame.Navigate(win_all);

        }




        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        bool flag1 = true;
        private void Button_Click_Open_all_train(object sender, RoutedEventArgs e)
        {
            All_train win_all = new All_train(user);
            this.Main_Frame.Navigate(win_all);
        }

        private void Button_Click_Open_user_train(object sender, RoutedEventArgs e)
        {

            MainTrainWin win_main = new MainTrainWin(user);
            win_main = this;

            User_train win_user = new User_train(user);
            win_user.Obj(win_main);
            this.Main_Frame.Navigate(win_user);
        }

        private void Button_Click_Open_groupe_train(object sender, RoutedEventArgs e)
        {
            Groupe_train win_gr = new Groupe_train(user);

            this.Main_Frame.Navigate(win_gr);
        }

        private void Button_Click_Create_Train(object sender, RoutedEventArgs e)
        {
            var win_creat = new DoubleWin(user);
            win_creat.Choose_frame(1);

            win_creat.Show();

            this.Close();

        }

        private void Button_Another_User(object sender, RoutedEventArgs e)
        {
            var win_ch = new chose_login();
            win_ch.Show();
            this.Close();
        }

        private void Button_Click_Open_statistics(object sender, RoutedEventArgs e)
        {
            var win_stat = new Statistics_train(user);
            this.Main_Frame.Navigate(win_stat);
        }

        private void Button_Click_Open_train(object sender, RoutedEventArgs e)
        {
            if (flag1)
            {
                this.Open_all_train.Visibility = Visibility.Visible;
                this.Open_groupr_train.Visibility = Visibility.Visible;
                this.Open_user_train.Visibility = Visibility.Visible;
                this.Create_new_train.Visibility = Visibility.Visible;
                flag1 = false;
            }
            else
            {
                this.Open_all_train.Visibility = Visibility.Hidden;
                this.Open_groupr_train.Visibility = Visibility.Hidden;
                this.Open_user_train.Visibility = Visibility.Hidden;
                this.Create_new_train.Visibility = Visibility.Hidden;
                flag1 = true;
            }
        }


        bool flag2 = true;
        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {

            if (flag2)
            {
                this.Weight.Visibility = Visibility.Hidden;
                this.Add_weight.Visibility = Visibility.Visible;
                this.Button_update.Content = "Сохранить";
                flag2 = false;



            }
            else
            {
                this.Weight.Visibility = Visibility.Visible;
                this.Add_weight.Visibility = Visibility.Hidden;
                this.Weight.Text = this.Add_weight.Text;
                this.Button_update.Content = "Обновить";
                flag2 = true;
            }
        }

        private void Open_train_MouseEnter(object sender, MouseEventArgs e)
        {

            this.Open_all_train.Visibility = Visibility.Visible;
            this.Open_groupr_train.Visibility = Visibility.Visible;
            this.Open_user_train.Visibility = Visibility.Visible;
            this.Create_new_train.Visibility = Visibility.Visible;



        }

        private void Open_train_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Open_all_train.Visibility = Visibility.Hidden;
            this.Open_groupr_train.Visibility = Visibility.Hidden;
            this.Open_user_train.Visibility = Visibility.Hidden;
            this.Create_new_train.Visibility = Visibility.Hidden;
        }

        private void Button_Click_All_Ex(object sender, RoutedEventArgs e)
        {
            var win_ex = new DoubleWin(user);
            this.Close();
            win_ex.Choose_frame(2);
            win_ex.Show();

        }
    }

}

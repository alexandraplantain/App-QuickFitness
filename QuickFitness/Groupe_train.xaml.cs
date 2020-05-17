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
using QuickFitness.Models;
using System.Data.Entity;

namespace QuickFitness
{
    /// <summary>
    /// Логика взаимодействия для Groupe_train.xaml
    /// </summary>
    public partial class Groupe_train : Page
    {
        User user;
        //перемнная для условия глобальная
        public Groupe_train(User us)
        {
            user = us;
            InitializeComponent();

            var panel = new StackPanel();
            using (TrainingContext db = new TrainingContext())
            {
                db.Trainings.Load();
                var list = db.Trainings.Local.ToBindingList();
                foreach (var item in list)
                {
                    if (item.Groupe == 1)
                    {
                        var a = new TrainBlock(item, user);
                        panel.Children.Add(a);
                    }
                }


            }
            this.List_train.Content = panel;
        }

       

       

        private void Button_first_Click(object sender, RoutedEventArgs e)
        {
            this.Button_first.Background = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            this.Button_first.Foreground = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            this.Button_second.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_second.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            this.Button_third.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_third.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            this.Button_four.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_four.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            var panel = new StackPanel();
            using(TrainingContext db = new TrainingContext())
            {
                db.Trainings.Load();
                var list = db.Trainings.Local.ToBindingList();
                foreach (var item in list)
                {
                    if (item.Groupe == 1 && item.ID_type == 0)
                    {
                        var a = new TrainBlock(item, user);
                        panel.Children.Add(a);
                    }
                }             
            }
            this.List_train.Content = panel;
        }

        private void Button_second_Click(object sender, RoutedEventArgs e)
        {
            this.Button_first.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_first.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Button_second.Background = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            this.Button_second.Foreground = new SolidColorBrush(Color.FromRgb(254, 95, 27));

            this.Button_third.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_third.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Button_four.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_four.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            var panel = new StackPanel();
            using (TrainingContext db = new TrainingContext())
            {
                db.Trainings.Load();
                var list = db.Trainings.Local.ToBindingList();
                foreach (var item in list)
                {
                    if (item.Groupe == 2 && item.ID_type == 0)
                    {
                        var a = new TrainBlock(item, user);
                        panel.Children.Add(a);
                    }
                }


            }
            this.List_train.Content = panel;
        }

        private void Button_third_Click(object sender, RoutedEventArgs e)
        {
            this.Button_first.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_first.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Button_second.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_second.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Button_third.Background = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            this.Button_third.Foreground = new SolidColorBrush(Color.FromRgb(254, 95, 27));

            this.Button_four.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_four.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            var panel = new StackPanel();
            using (TrainingContext db = new TrainingContext())
            {
                db.Trainings.Load();
                var list = db.Trainings.Local.ToBindingList();
                foreach (var item in list)
                {
                    if (item.Groupe == 3 && item.ID_type == 0)
                    {
                        var a = new TrainBlock(item, user);
                        panel.Children.Add(a);
                    }
                }


            }
            this.List_train.Content = panel;
        }

        private void Button_four_Click(object sender, RoutedEventArgs e)
        {
            this.Button_first.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_first.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Button_second.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_second.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Button_third.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_third.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Button_four.Background = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            this.Button_four.Foreground = new SolidColorBrush(Color.FromRgb(254, 95, 27));

            var panel = new StackPanel();
            using (TrainingContext db = new TrainingContext())
            {
                db.Trainings.Load();
                var list = db.Trainings.Local.ToBindingList();
                foreach (var item in list)
                {
                    if (item.Groupe == 4 && item.ID_type==0)
                    {
                        var a = new TrainBlock(item, user);
                        panel.Children.Add(a);
                    }
                }


            }
            this.List_train.Content = panel;
        }
    }
}

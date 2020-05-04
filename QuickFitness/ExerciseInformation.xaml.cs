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
using System.Text.RegularExpressions;

namespace QuickFitness
{
    /// <summary>
    /// Логика взаимодействия для ExerciseInformation.xaml
    /// </summary>
    /// 

    public partial class ExerciseInformation : Page
    {

        public ExerciseInformation()
        {
            InitializeComponent();

            var panel = new StackPanel();
            using (ExerciseContext db = new ExerciseContext())
            {
                db.Exercises.Load();
                var list = db.Exercises.Local.ToBindingList();
                foreach (var item in list)
                {
                    var a = new Exercise_block_learn(item);
                    panel.Children.Add(a);

                }
            }
            this.List_train.Content = panel;
        }
      

        private void Button_intens_one_Click(object sender, RoutedEventArgs e)
        {
            this.Button_intens_one.Background = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            this.Button_intens_two.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_intens_three.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            Intensity_num = 1;
        }

        private void Button_intens_two_Click(object sender, RoutedEventArgs e)
        {
            this.Button_intens_one.Background = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            this.Button_intens_two.Background = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            this.Button_intens_three.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            Intensity_num = 2;
        }

        private void Button_intens_three_Click(object sender, RoutedEventArgs e)
        {
            this.Button_intens_one.Background = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            this.Button_intens_two.Background = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            this.Button_intens_three.Background = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            Intensity_num = 3;
        }

        private void Groupe_1_Click(object sender, RoutedEventArgs e)
        {
            this.Groupe_1.Background = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            this.Groupe_1.Foreground = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            this.Groupe_2.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Groupe_2.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            this.Groupe_3.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Groupe_3.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            this.Groupe_4.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Groupe_4.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            Groupe_num = 1;

        }

        private void Groupe_2_Click(object sender, RoutedEventArgs e)
        {
            this.Groupe_1.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Groupe_1.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Groupe_2.Background = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            this.Groupe_2.Foreground = new SolidColorBrush(Color.FromRgb(254, 95, 27));

            this.Groupe_3.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Groupe_3.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Groupe_4.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Groupe_4.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            Groupe_num = 2;
        }

        private void Groupe_3_Click(object sender, RoutedEventArgs e)
        {
            this.Groupe_1.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Groupe_1.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Groupe_2.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Groupe_2.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Groupe_3.Background = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            this.Groupe_3.Foreground = new SolidColorBrush(Color.FromRgb(254, 95, 27));

            this.Groupe_4.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Groupe_4.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            Groupe_num = 3;
        }

        private void Groupe_4_Click(object sender, RoutedEventArgs e)
        {
            this.Groupe_1.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Groupe_1.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Groupe_2.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Groupe_2.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Groupe_3.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Groupe_3.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Groupe_4.Background = new SolidColorBrush(Color.FromRgb(222, 222, 222));
            this.Groupe_4.Foreground = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            Groupe_num = 4;
        }

        int Groupe_num = 0;
        int Intensity_num = 0;

        private void Button_Click_Search(object sender, RoutedEventArgs e)
        {
            var panel = new StackPanel();
            List<Exercise> search = new List<Exercise>();
            using (ExerciseContext db = new ExerciseContext())
            {
                db.Exercises.Load();
                var list = db.Exercises.Local.ToBindingList();

                if (this.Search_name.Text != "")
                {
                    string ser_name;
                    ser_name = this.Search_name.Text;
                    Regex text = new Regex(ser_name, RegexOptions.IgnoreCase);
                    foreach (var item in list)
                    {
                        string line = item.Name_ex.ToString();
                        MatchCollection matches = text.Matches(line);
                        if (matches.Count > 0)
                        {
                            search.Add(item);
                        }
                    }
                }
                if(Groupe_num!=0)
                {
                    if(search.Count!=0)
                    {
                        List<Exercise> search_step = new List<Exercise>();
                        foreach (var item in search)
                        {
                            search_step.Add(item);
                        } 
                        search.Clear();
                        foreach(var item in search_step)
                        {
                            if (item.Groupe == Groupe_num)
                            {
                                search.Add(item);
                            }
                        }
                    }
                    else
                    {
                        foreach(var item in list)
                        {
                            if(item.Groupe==Groupe_num)
                            {
                                search.Add(item);
                            }
                        }
                    }
                }
                if(Intensity_num!=0)
                {
                    if(search.Count != 0)
                    {
                        List<Exercise> search_step = new List<Exercise>();

                        foreach (var item in search)
                        {
                            search_step.Add(item);
                        }
                        search.Clear();
                        foreach (var item in search_step)
                        {
                            if (item.Intensity == Intensity_num)
                            {
                                search.Add(item);
                            }
                        }
                    }
                    else
                    {
                        foreach (var item in list)
                        {
                            if (item.Intensity == Intensity_num)
                            {
                                search.Add(item);
                            }
                        }
                    }
                }

            }

            foreach (var item in search)
            {
                var a = new Exercise_block_learn(item);
                panel.Children.Add(a);
            }
            this.List_train.Content = panel;

            this.Groupe_1.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Groupe_1.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Groupe_2.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Groupe_2.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Groupe_3.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Groupe_3.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Groupe_4.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Groupe_4.Foreground = new SolidColorBrush(Color.FromRgb(222, 222, 222));

            this.Button_intens_one.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_intens_two.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));
            this.Button_intens_three.Background = new SolidColorBrush(Color.FromRgb(67, 67, 67));

            Groupe_num = 0;
            Intensity_num = 0;
        }


    }
}

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
    /// Логика взаимодействия для Create_train.xaml
    /// </summary>
    public partial class Create_train : Page
    {
        User user;
        List<Exercise> list_ex = new List<Exercise>();
        DoubleWin win_c;

        public Create_train(User us, DoubleWin w)
        {
            user = us;
            InitializeComponent();
            win_c = w;
           var panel = new StackPanel();
            using (ExerciseContext db = new ExerciseContext())
            {
                db.Exercises.Load();
                var list = db.Exercises.Local.ToBindingList();
                
                foreach(var item in list)
                {
                    var a = new Exercise_block_check(item, this);
                    list_ex.Add(item);
                    panel.Children.Add(a);

                }
            }
           this.List_train.Content = panel;
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
            
            using(ExerciseContext db = new ExerciseContext())
            {
                var panel = new StackPanel();
                db.Exercises.Load();
                var list = db.Exercises.Local.ToBindingList();
                foreach(var item in list)
                {
                    if(item.Groupe==1)
                    {
                        var a = new Exercise_block_check(item, this);
                        panel.Children.Add(a);
                    }
                }
                this.List_train.Content = panel;
            }
            

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

            using (ExerciseContext db = new ExerciseContext())
            {
                var panel = new StackPanel();
                db.Exercises.Load();
                var list = db.Exercises.Local.ToBindingList();
                foreach (var item in list)
                {
                    if (item.Groupe == 2)
                    {
                        var a = new Exercise_block_check(item, this);
                        panel.Children.Add(a);
                    }
                }
                this.List_train.Content = panel;
            }
            
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

            using (ExerciseContext db = new ExerciseContext())
            {
                var panel = new StackPanel();
                db.Exercises.Load();
                var list = db.Exercises.Local.ToBindingList();
                foreach (var item in list)
                {
                    if (item.Groupe == 3)
                    {
                        var a = new Exercise_block_check(item, this);
                        panel.Children.Add(a);
                    }
                }
                this.List_train.Content = panel;
            }
            
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
            
            using (ExerciseContext db = new ExerciseContext())
            {
                var panel = new StackPanel();
                db.Exercises.Load();
                var list = db.Exercises.Local.ToBindingList();
                foreach (var item in list)
                {
                    if (item.Groupe == 4)
                    {
                        var a = new Exercise_block_check(item, this);
                        panel.Children.Add(a);
                    }
                }
                this.List_train.Content = panel;
            }
            
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
            type_train = 1;
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
            type_train = 2;
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
            type_train = 3;
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
            type_train = 4;
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

        int time_ex_all=0;
        int time_min;

        public void Take_ex(int i)
        {
            list_ex_id.Add(i);

            foreach (var item in list_ex)
            {
                if (item.ID_ex == i)
                {
                    time_ex_all = time_ex_all + item.Time;
                }
            }
            
            if(list_ex_id.Count>1 )
            {
                time_ex_all = time_ex_all + 15;
            }

            var ts = TimeSpan.FromSeconds(time_ex_all);

            this.Time.Text = ts.Minutes.ToString() + " мин";

        }

        

        public void Remove_ex(int i)
        {


            list_ex_id.Remove(i);
            foreach (var item in list_ex)
            {
                if (item.ID_ex == i)
                {
                    time_ex_all = time_ex_all - item.Time;
                }
            }
            if(time_ex_all>1)
            {
                time_ex_all = time_ex_all - 15;
            }
            var ts = TimeSpan.FromSeconds(time_ex_all);

            this.Time.Text = ts.Minutes.ToString() + " мин";


        }

       

        
        int Intensity_num = 0;
        int type_train = 0;
     public List<int> list_ex_id = new List<int>();

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            int id_train;
            using (TrainingContext db = new TrainingContext())
            {
                Training new_train = new Training { Name_training = this.new_name.Text, Description = this.new_Disc.Text, Groupe = type_train, ID_training = 1, ID_type = user.ID_user, Img = "dvfd", Intensity = Intensity_num, Time = time_ex_all };
                db.Trainings.Add(new_train);
                db.SaveChanges();
                
            }
            using(TrainingContext db = new TrainingContext())
            {
                db.Trainings.Load();
                var list = db.Trainings.Local.ToBindingList();
                id_train = list.Count;
            }
            using(ConnectionContext db = new ConnectionContext())
            {
                foreach (var item in list_ex_id)
                {
                    var new_con = new Connection { ID_note = 1, ID_ex = item, ID_training = id_train, };
                    db.Connections.Add(new_con);
                }
                db.SaveChanges();
            }
            var win_user_train = new MainTrainWin(user);
            win_user_train.Show();
            win_c.Close();

        }
    }
}

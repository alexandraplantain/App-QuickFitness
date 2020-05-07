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
using LiveCharts;
using LiveCharts.Wpf;

namespace QuickFitness
{
    /// <summary>
    /// Логика взаимодействия для Statistics_train.xaml
    /// </summary>
    public partial class Statistics_train : Page
    {
        User user;
        List<Connection> list_con = new List<Connection>();
        string weight;
        List<Exercise> list_ex = new List<Exercise>();
        List<Training> list_train = new List<Training>();
        int kol_ex = 0;
        int kol_train = 0;
        int weight_up = 0;
        int time = 0;


        public Statistics_train(User us)
        {
            user = us;
            InitializeComponent();
            weight = user.Weight_start;
            using (ExerciseContext db = new ExerciseContext())
            {
                db.Exercises.Load();
                var list = db.Exercises.Local.ToBindingList();
                foreach (var item in list)
                {
                    list_ex.Add(item);
                }
            }

            using (ConnectionContext db = new ConnectionContext())
            {
                db.Connections.Load();
                var list = db.Connections.Local.ToBindingList();
                foreach (var item in list)
                {
                    list_con.Add(item);

                }
            }

            using (TrainingContext db = new TrainingContext())
            {
                db.Trainings.Load();
                var list = db.Trainings.Local.ToBindingList();
                foreach (var item in list)
                {
                    if (item.ID_type == 0 || item.ID_type == user.ID_user)
                    {
                        list_train.Add(item);
                    }

                }
            }

            using (StaticsticContext db = new StaticsticContext())
            {
                db.Staticstics.Load();
                var list = db.Staticstics.Local.ToBindingList();
                foreach (var item in list)
                {


                    if (item.ID_user == user.ID_user)
                    {
                        if (item.Weight_note != weight)
                        {
                            weight_up++;
                            weight = item.Weight_note;
                        }
                        bool flag = true;
                        int id = 0;
                        foreach (var item_con in list_con)
                        {
                            if (item.ID_training == item_con.ID_training)
                            {
                                if (flag)
                                {
                                    id = item.ID_training;
                                    foreach (var item_tr in list_train)
                                    {
                                        if (item_tr.ID_training == item_con.ID_training)
                                        {
                                            time = time + item_tr.Time;
                                        }
                                    }

                                    kol_train++;
                                    flag = false;
                                }
                                if(id!=item.ID_training)
                                {
                                    flag = true;
                                }
                                foreach (var item_ex in list_ex)
                                {
                                    int kol_1 = 0;
                                    int kol_2 = 0;
                                    int kol_3 = 0;
                                    int kol_4 = 0;
                                    if (item_ex.ID_ex == item_con.ID_ex)
                                    {
                                        kol_ex++;
                                        switch (item_ex.Groupe)
                                        {
                                            case 1:
                                                kol_1++;
                                                break;
                                            case 2:
                                                kol_2++;
                                                break;
                                            case 3:
                                                kol_3++;
                                                break;
                                            case 4:
                                                kol_4++;
                                                break;
                                        }
                                    }
                                    Pie_Stat(kol_1, kol_2, kol_3, kol_4);
                                }
                            }
                        }
                    }
                }
            }

            this.Kol_ex_stat.Text = kol_ex.ToString();
            this.Kol_train_stat.Text = kol_train.ToString();
            this.Kol_update_stat.Text = weight_up.ToString();
            Take_time();
            Progres_weight();
        }


        private void Progres_weight()
        {
            if (Convert.ToDouble(user.Weight_goal) >= Convert.ToDouble(weight))
            {
                this.Progress.Value = 100;
            }
            else
            {
                this.Progress.Value = (   Convert.ToDouble(weight)  - Convert.ToDouble(user.Weight_goal)  ) / (    Convert.ToDouble(user.Weight_start) -  Convert.ToDouble(user.Weight_goal) ) ;
            }
        }

        private void Take_time()
        {
            var ts = TimeSpan.FromSeconds(time);
            this.Kol_hours_stat.Text = ts.Hours.ToString();
            this.Kol_min_stat.Text = ts.Minutes.ToString();
        }


        private void Pie_Stat(int k1, int k2, int k3, int k4)
        {
            if (k1 == 0 && k2 == 0 && k3 == 0 && k4 == 0)
            {
                this.Back_pie.Visibility = Visibility.Visible;
            }
            else
            {
                this.Pie_1.Values = new ChartValues<double> { k1 };
                this.Pie_2.Values = new ChartValues<double> { k2 };
                this.Pie_3.Values = new ChartValues<double> { k3 };
                this.Pie_4.Values = new ChartValues<double> { k4 };
                this.Back_pie.Visibility = Visibility.Hidden;
            }
        }


    }
}

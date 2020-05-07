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
    /// Логика взаимодействия для Info_train.xaml
    /// </summary>
    public partial class Info_train : Window
    {
        User user;
        Training train;
        int time;
        int day=0;
        public Info_train(Training tr, User us)
        {
            InitializeComponent();
            user = us;
            train = tr;

            this.Name_train.Text = tr.Name_training.ToString();
            Show_min(tr.Time);
            this.Img_train.Source = new BitmapImage(new Uri("pack://application:,,,/QuickFitness;component/Resources/AllPic/Training/train.png"));
            this.Train_time.Text = time.ToString() + " мин";
            this.Train_info.Text = train.Description.ToString();
            ChooseIntensity(train.Intensity);

            using (StaticsticContext db = new StaticsticContext())
            {
                db.Staticstics.Load();
                var list = db.Staticstics.Local.ToBindingList();
                foreach (var item in list)
                {
                    if(item.ID_user==user.ID_user && item.ID_training==train.ID_training)
                    {
                        day++;
                    }
                }
            }



                    Fiil_progress(day); //в днях

        }

         

        public void Take_Stat()
        {
            using (StaticsticContext db = new StaticsticContext())
            {
                string weight=null;
                db.Staticstics.Load();
                var list = db.Staticstics.Local.ToBindingList();
                foreach(var item in list)
                {
                    if (item.ID_user == user.ID_user)
                    {
                        weight = item.Weight_note;                        
                    }
                    else
                    {
                        weight = user.Weight_start;
                    }
                    if (item.ID_user == user.ID_user && item.ID_training == train.ID_training)
                    {
                        day++;
                    }
                }
                DateTime data = DateTime.Now;
                var new_stat = new Staticstic { ID_session = 1, ID_training = train.ID_training, ID_user = user.ID_user, Time = train.Time, Weight_note = weight, Data_traning = data.ToString() };
                db.Staticstics.Add(new_stat);
                db.SaveChanges();
                Fiil_progress(day); //в днях

            }
        }

        private void Show_min(int s)
        {
            var result = Math.Round((double)s / 60);
            time = (int)result;
        }

        private void ChooseIntensity(int i)
        {
            if (i == 1)
            {
                this.Int1.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            }
            else if (i == 2)
            {
                this.Int1.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                this.Int2.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            }
            else
            {
                this.Int1.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                this.Int2.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                this.Int3.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            }
        }

        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        public void Fiil_progress(int kol)
        {
            if (kol <= 7)
            {
                this.First_week.Send_kol(kol);
            }
            else
            {
                if (kol <= 14)
                {
                    this.Progress_bar_registr.Value = 50;
                    this.First_week.Send_kol(7);
                    this.Second_week.Send_kol(kol - 7);
                }
                else
                {
                    if (kol <= 21)
                    {
                        this.Progress_bar_registr.Value = 75;
                        this.First_week.Send_kol(7);
                        this.Second_week.Send_kol(7);
                        this.Third_week.Send_kol(kol - 14);
                    }
                    else
                    {
                        this.Progress_bar_registr.Value = 100;
                        this.First_week.Send_kol(7);
                        this.Second_week.Send_kol(7);
                        this.Third_week.Send_kol(7);
                        this.Four_week.Send_kol(kol - 21);
                    }

                }
            }
        }


        private void Button_Click_Start(object sender, RoutedEventArgs e)
        {
            var list_ex = new List<Exercise>();
            using (ConnectionContext db = new ConnectionContext())
            {
                db.Connections.Load();
                var list = db.Connections.Local.ToBindingList();
                foreach (var item in list)
                {
                    if (item.ID_training == train.ID_training)
                    {
                        using (ExerciseContext dp = new ExerciseContext())
                        {
                            dp.Exercises.Load();
                            var list_e = dp.Exercises.Local.ToBindingList();
                            foreach (var item2 in list_e)
                            {
                                if (item2.ID_ex == item.ID_ex)
                                {
                                    list_ex.Add(item2);
                                }
                            }
                        }
                    }
                }
            }

            Exercise[] array_ex = new Exercise[list_ex.Count];
            int kl = 0;
            foreach (var item in list_ex)
            {
                array_ex[kl] = item;
                kl++;
            }


            var win_on = new Training_On(user, train, array_ex, kl);
            
            win_on.Show();
            this.Close();
        }

        private void Button_go_to_all_train(object sender, RoutedEventArgs e)
        {
            var win = new MainTrainWin(user);
            win.Show();
            this.Close();
        }
    }
}

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
    /// Логика взаимодействия для TrainBlock.xaml
    /// </summary>
    public partial class TrainBlock : UserControl
    {
      public  Training train;
      public  User user;
        int time;
        public TrainBlock(Training tr, User us)
        {
            train = tr;
            user = us;
            InitializeComponent();
            this.Name_train.Text = tr.Name_training;
            Show_min(tr.Time);
          this.Img_train.Source = new BitmapImage(new Uri("pack://application:,,,/QuickFitness;component/Resources/AllPic/Training/train.png"));
            this.Time.Text = time + " мин";
            this.Info.Text = tr.Description;
            ChooseIntensity(tr.Intensity);

            this.RenderSize = new Size(1016, 239);
        }
        private void Show_min(int s)
        {
            var result = Math.Round((double)s / 60);
            time = (int)result;
        }

        private void ChooseIntensity(int i)
        {
            if(i==1)
            {
                this.int1.Fill= new SolidColorBrush(Color.FromRgb(254, 95, 27));
            }
            else if (i==2)
            {
                this.int1.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                this.int2.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            }
            else
            {
                this.int1.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                this.int2.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                this.int3.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
            }
        }

        private void Button_start_Click(object sender, RoutedEventArgs e)
        {
            Info_train win = new Info_train(train, user);
            win.Show();
            MainTrainWin wind = (MainTrainWin)Window.GetWindow(this);
            wind.Close();
            

        }
    }
}

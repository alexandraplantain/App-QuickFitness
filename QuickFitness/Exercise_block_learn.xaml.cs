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
    /// Логика взаимодействия для Exercise_block_learn.xaml
    /// </summary>
    public partial class Exercise_block_learn : UserControl
    {
        Exercise exercise;
        ExerciseInformation win;
        public Exercise_block_learn(Exercise ex, ExerciseInformation w)
        {
            InitializeComponent();
            exercise = ex;
            win = w;
            this.Name_ex.Text = ex.Name_ex;
           ChooseIntensity(ex.Intensity, 1);
            ChooseGroupe(ex.Groupe, 1);
            this.Time_ex.Text = "0:" + ex.Time.ToString() + " мин";


        }

        private void ChooseGroupe(int g, int z)
        {
            switch (g)
            {
                case 1:
                    if (z == 1)
                    {
                        this.Name_groupe.Text = "Руки и спина";
                    }
                    else
                    {
                        win.Groupe.Text= "Руки и спина";
                    }
                    break;
                    
                case 2:
                    if (z == 1)
                    {
                        this.Name_groupe.Text = "Растяжка";
                    }
                    else
                    {
                        win.Groupe.Text = "Растяжка";
                    }
                    break;
                case 3:
                    if (z == 1)
                    {
                        this.Name_groupe.Text = "Ноги и ягодицы";
                    }
                    else
                    {
                        win.Groupe.Text = "Ноги и ягодицы";
                    }
                    break;
                case 4:
                    if (z == 1)
                    {
                        this.Name_groupe.Text = "Пресс";
                    }
                    else
                    {
                        win.Groupe.Text = "Пресс";
                    }
                    break;
            }
        }

        private void ChooseIntensity(int i, int z)
        {
            if (i == 1)
            {
                if (z == 1)
                {
                    this.Int1.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                }
                else
                {
                    win.Int_1.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                    win.Int_2.Fill = new SolidColorBrush(Color.FromRgb(67, 67, 67));
                    win.Int_3.Fill = new SolidColorBrush(Color.FromRgb(67, 67, 67));
                }
            }
            else if (i == 2)
            {
                if (z == 1)
                {
                    this.Int1.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                    this.Int2.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                }
                else
                {
                    win.Int_1.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                    win.Int_2.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                    win.Int_3.Fill = new SolidColorBrush(Color.FromRgb(67, 67, 67));
                }
            }
            else
            {
                if (z == 1)
                {
                    this.Int1.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                    this.Int2.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                    this.Int3.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                }
                else
                {
                    win.Int_1.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                    win.Int_2.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                    win.Int_3.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                }
            }
        }

        private void Input_Img()
        {
            win.Img1.Source= new BitmapImage(new Uri("pack://application:,,,/QuickFitness;component/Resources/AllPic" + exercise.Img_one));
            win.Img2.Source = new BitmapImage(new Uri("pack://application:,,,/QuickFitness;component/Resources/AllPic" + exercise.Img_two));
        }    

        private void Button_learn_Click(object sender, RoutedEventArgs e)
        {
            win.Learn.Visibility = Visibility.Visible;
            win.Back_info.Visibility = Visibility.Hidden;
            win.Name_ex.Text = exercise.Name_ex;

            //win.Disc_ex.Text = exercise.Decription;
            ChooseGroupe(exercise.Groupe, 2);
            ChooseIntensity(exercise.Intensity, 2);
            Input_Img();

        }
    }
}

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
    /// Логика взаимодействия для Exercise_block_check.xaml
    /// </summary>
    public partial class Exercise_block_check : UserControl
    {
        Exercise exercise;
        Create_train win;
        public Exercise_block_check(Exercise ex, Create_train w)
        {
            InitializeComponent();
            exercise = ex;
            win = w;
            this.Name_ex.Text = ex.Name_ex;
            this.Time_ex.Text = "0:" + ex.Time.ToString() + " мин";
            ChooseIntensity(ex.Intensity);
            ChooseGroupe(ex.Groupe);
        }
       
        bool flag = true;

        private void ChooseGroupe(int g)
        {
            switch (g)
            {
                case 1:                    
                    this.Groupe.Text = "Руки и спина";                    
                    break;

                case 2:
                    this.Groupe.Text = "Растяжка";                   
                    break;

                case 3:
                    this.Groupe.Text = "Ноги и ягодицы";                    
                    break;

                case 4:
                    this.Groupe.Text = "Пресс";                    
                    break;
            }
        }

        private void ChooseIntensity(int i)
        {
            if (i == 1)
            {               
                    this.Int_1.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));               
            }
            else if (i == 2)
            {                
                    this.Int_1.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                    this.Int_2.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));               
            }
            else
            {                
                    this.Int_1.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                    this.Int_2.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));
                    this.Int_3.Fill = new SolidColorBrush(Color.FromRgb(254, 95, 27));                
            }
        }

        private void Button_Check_Click(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                this.Button_Check.Background = new SolidColorBrush(Color.FromRgb(112, 112, 112));
                win.Take_ex(exercise.ID_ex);
                
                flag = false;
            }
            else
            {
                this.Button_Check.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
                win.Remove_ex(exercise.ID_ex);
                flag = true;
            }
        }

        private void Button_Check_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}

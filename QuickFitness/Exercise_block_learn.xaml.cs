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
        public Exercise_block_learn(Exercise ex)
        {
            InitializeComponent();
            exercise = ex;
            this.Name_ex.Text = ex.Name_ex;
           ChooseIntensity(ex.Intensity);
            ChooseGroupe(ex.Groupe);
            this.Time_ex.Text = "0:" + ex.Time.ToString() + " мин";


        }

        private void ChooseGroupe(int g)
        {
            switch (g)
            {
                case 1:
                    this.Name_groupe.Text = "Руки и спина";
                    break;
                case 2:
                    this.Name_groupe.Text = "Растяжка";
                    break;
                case 3:
                    this.Name_groupe.Text = "Ноги и ягодицы";
                    break;
                case 4:
                    this.Name_groupe.Text = "Пресс";
                    break;
            }
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
    }
}

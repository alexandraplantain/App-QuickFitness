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
    /// Логика взаимодействия для All_train.xaml
    /// </summary>
    public partial class All_train : Page
    {
        User user;
        public All_train(User us)
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
                    var a = new TrainBlock(item, us);
                    panel.Children.Add(a);
                }
                this.List_train.Content = panel;

            }
           
            
        }

    }
}

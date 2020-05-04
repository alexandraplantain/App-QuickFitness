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
    /// Логика взаимодействия для User_train.xaml
    /// </summary>
    public partial class User_train : Page
    {
        User user;
        bool flag = true;
        public User_train(User us)
        {
            InitializeComponent();
            user = us;
            var panel = new StackPanel();
            using (TrainingContext db = new TrainingContext())
            {
                db.Trainings.Load();
                var list = db.Trainings.Local.ToBindingList();
                foreach (var item in list)
                {
                    if (item.ID_type == us.ID_user)
                    {
                        var a = new TrainBlock(item, user);
                        panel.Children.Add(a);
                        flag = false;
                    }
                    
                }


            }
            this.List_train.Content = panel;

        }

        public void Obj(MainTrainWin e)
        {
            if (flag)
            {
                var win_an = new ANNOUNCEMENTNoWorkoutsCreated(user);
                
                win_an.Object_sends(e);
                win_an.Show();
            }
           
        }
       
    }
}

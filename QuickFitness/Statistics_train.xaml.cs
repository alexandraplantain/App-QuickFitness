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
    /// Логика взаимодействия для Statistics_train.xaml
    /// </summary>
    public partial class Statistics_train : Page
    {
        User user;
        public Statistics_train(User us)
        {
            user = us;
            InitializeComponent();
        }
    }
}

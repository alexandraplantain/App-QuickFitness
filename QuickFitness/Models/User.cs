using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Data.Entity;

namespace QuickFitness.Models
{
   public class User
    {
        [Key]
        public int ID_user { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Weight_start { get; set; }
        public string Weight_goal { get; set; }
        public string Data_start { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}

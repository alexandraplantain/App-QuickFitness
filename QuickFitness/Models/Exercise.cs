using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace QuickFitness.Models
{
   public class Exercise
    {
        [Key]
        public int ID_ex { get; set; }
        public string Name_ex { get; set; }
        public int Groupe { get; set; }
        public int Time { get; set; }
        public string Decription { get; set; }
        public int Intensity { get; set; }
        public string Img_one { get; set; }
        public string Img_two { get; set; }
    }
}

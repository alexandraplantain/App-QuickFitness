using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace QuickFitness.Models
{
    public class Training
    {
        [Key]
        public int ID_training { get; set; }
       
        public string Name_training { get; set; }
        public int Time { get; set; }
        public string Description { get; set; }
        public int Intensity { get; set; }
        public int Groupe { get; set; }
        public string Img { get; set; }
        public int ID_type { get; set; }
    }
}

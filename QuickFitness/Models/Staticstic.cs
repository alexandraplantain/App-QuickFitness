using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace QuickFitness.Models
{
    public class Staticstic
    { 
        [Key]
        public int ID_session { get; set; }
        public int ID_training { get; set; }
        public int ID_user { get; set; }
        public int Time { get; set; }
        public string Data_traning { get; set; }
        public string Weight_note { get; set; }

    }
}

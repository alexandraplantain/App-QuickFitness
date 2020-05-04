using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace QuickFitness.Models
{
    class Connection
    {
        [Key]
        public int ID_note { get; set; }
        public int ID_training { get; set; }
        public int ID_ex { get; set; }
    }
}

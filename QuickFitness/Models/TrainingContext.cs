using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace QuickFitness.Models
{
    class TrainingContext :DbContext
    {
        public TrainingContext() : base("DefaultConnection")
        {

        }

        public DbSet<Training>Trainings { get; set; }
    }
    
    
}

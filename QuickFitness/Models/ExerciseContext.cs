using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace QuickFitness.Models
{
    class ExerciseContext :DbContext
    {
        public ExerciseContext() : base("DefaultConnection")
        { }

        public DbSet<Exercise> Exercises { get; set; }
    }
}

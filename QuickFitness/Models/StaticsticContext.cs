using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace QuickFitness.Models
{
    class StaticsticContext : DbContext
    {
        public StaticsticContext() : base("DefaultConnection")
        {

        }

        public DbSet<Staticstic> Staticstics { get; set; }
    }
}

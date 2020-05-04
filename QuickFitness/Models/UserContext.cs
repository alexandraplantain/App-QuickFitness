using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace QuickFitness.Models
{
    class UserContext:DbContext
    {
        public UserContext():base("DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}

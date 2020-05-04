using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace QuickFitness.Models
{
    class ConnectionContext:DbContext
    {
        public ConnectionContext() : base("DefaultConnection")
        {

        }

        public DbSet<Connection> Connections { get; set; }
    }
}

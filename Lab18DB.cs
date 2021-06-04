using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Lab_18
{
    public class Lab18DB : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<PlaneTiket> PlaneTikets { get; set; }
        public DbSet<Airport> Airports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Server = HOME; Database = Lab18; Trusted_Connection = True; MultipleActiveResultSets = true");
        }
    }
}

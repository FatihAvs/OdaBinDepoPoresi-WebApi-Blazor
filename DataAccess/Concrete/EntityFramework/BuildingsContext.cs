using Microsoft.EntityFrameworkCore;
using System;
using Entities.Concrete;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class BuildingsContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Building;Trusted_Connection=true");

        }
        public DbSet<Bina> Binalar { get; set; }
        public DbSet<Oda> Odalar { get; set; }
        public DbSet<Depo> Depolar { get; set; }

    }
}

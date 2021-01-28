using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NudelnDudeln.Models;

namespace NudelnDudeln.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<FoodUnit> FoodUnit { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<CurrencyUnit> Currency { get; set; }
        public virtual DbSet<Participant> Participant { get; set; }
        public virtual DbSet<Contribution> Contribution { get; set; }
        public virtual DbSet<Consumption> Consumption { get; set; }
    }
}

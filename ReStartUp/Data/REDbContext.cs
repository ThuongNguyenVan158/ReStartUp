using Microsoft.EntityFrameworkCore;
using ReStartUp.Data.Configurations;
using ReStartUp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReStartUp.Data
{
    public class REDbContext: DbContext
    {
        public REDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EmailConfiguration());

        }
        public DbSet<Email> EMAIL { get; set; }
    }
}

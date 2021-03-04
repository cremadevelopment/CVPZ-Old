using CVPZ.Core.Entities;
using CVPZ.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVPZ.Infrastructure.Data
{
    public class CVPZContext : DbContext
    {
        public CVPZContext(DbContextOptions<CVPZContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JournalEntry>()
                .Property(x => x.Description)
                .IsRequired();
        }

        public DbSet<JournalEntry> JournalEntries { get; set; }
    }
}

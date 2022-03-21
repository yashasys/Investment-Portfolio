using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InvestmentPortfolio.Models
{
    public partial class Investment_PortfolioContext : DbContext
    {
        public Investment_PortfolioContext()
        {
        }

        public Investment_PortfolioContext(DbContextOptions<Investment_PortfolioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Investment> Investment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Investment>(entity =>
            {
                

                entity.Property(e => e.Contact).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ProfilePicUrl).HasColumnName("ProfilePicURL");

                entity.Property(e => e.TotalInvestment).HasColumnType("decimal(18, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

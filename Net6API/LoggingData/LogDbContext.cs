using System;
using Microsoft.EntityFrameworkCore;

namespace Net6API.LoggingData
{
	public class LogDbContext : DbContext
	{
        public DbSet<LogError> LogError { get; set; }
        public LogDbContext(DbContextOptions<LogDbContext> dbContext) : base(dbContext)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo")
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<LogError>(entity =>
            {
                entity.ToTable("LogError");

                entity.HasKey("Id");

                entity.Property(e => e.ErrorDetails)
                    .IsRequired()
                    .IsUnicode(true);

                entity.Property(e => e.LogDate).HasColumnType("datetime");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}


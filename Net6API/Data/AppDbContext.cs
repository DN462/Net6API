using Microsoft.EntityFrameworkCore;

#nullable disable
namespace Net6API.Data
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<UserInformation> UsersInformation { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                throw new Exception();
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo")
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.HasKey("CountryId");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(true);

                entity.Property(e => e.CountryNameAcronym)
                   .IsRequired()
                   .HasMaxLength(10)
                   .IsUnicode(true);
            });
            modelBuilder.Entity<UserInformation>(entity =>
            {
                entity.ToTable("UserInformation");

                entity.HasKey("Id");

                entity
                    .HasIndex(e => e.Email)
                    .IsUnique();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(true);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(true);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(320)
                    .IsUnicode(true);

                entity.Property(e => e.StreetAddress)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(true);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(true);

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(true);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(true);

                entity.Property(e => e.CountryId)
                    .IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
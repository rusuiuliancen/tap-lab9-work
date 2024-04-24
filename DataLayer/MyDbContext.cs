using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    // dotnet ef migrations add Initial
    // dotnet ef database update
    public class MyDbContext : DbContext
    {
        //private readonly string _windowsConnectionString = @"Server=.\SQLExpress;Database=Lab5Database1;Trusted_Connection=True;TrustServerCertificate=true";
        //private readonly string _windowsConnectionString = @"Server=localhost\SQLEXPRESS;Database=Lab5Database1;Trusted_Connection=True;TrustServerCertificate=True;";
        private readonly string _windowsConnectionString = @"Data Source=NBKR004513;Initial Catalog=LabDatabaseSeed1;Integrated Security=True;TrustServerCertificate=True";
        
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_windowsConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
                .HasOne(f => f.Type)
                .WithMany(c => c.Users)
                .HasForeignKey(f => f.TypeId);

            Seed(builder);
        }

        protected void Seed(ModelBuilder modelBuilder)
        {
            var userTypeId1 = Guid.NewGuid();
            var userTypeId2 = Guid.NewGuid();

            modelBuilder.Entity<UserType>()
                .HasData(
                    new UserType(userTypeId1,"USER"), 
                    new UserType(userTypeId2, "ADMIN")
                    );

            modelBuilder.Entity<User>()
                .HasData(
                    new User(Guid.NewGuid(), "Popa Ion", "pop.ion@gmail.com","pass1", userTypeId1),
                    new User(Guid.NewGuid(), "Popa Ion2", "pop.ion2@gmail.com","pass1", userTypeId1),
                    new User(Guid.NewGuid(), "Sef Ion", "sef.ion2@gmail.com","pass1", userTypeId2),
                    new User(Guid.NewGuid(), "Sef Ion2", "sef.ion2@gmail.com","pass1", userTypeId2)
                    );
        }
    }
}

using BeautySalon.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Data
{
    public class BeautySalonContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("connection.json");
            var config = builder.Build();

            string conString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(conString); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(e =>
            {
                e.HasKey(x => x.Id);
                e.Property(x => x.Username).IsRequired().HasMaxLength(30).IsUnicode(true);
                e.HasIndex(x => x.Username).IsUnique();
                e.Property(x => x.Password).IsUnicode(true).IsRequired().HasMaxLength(30);
                e.Property(x => x.Role).HasConversion<string>();
            });

            modelBuilder.Entity<Client>(e =>
            {
                e.HasKey(x => x.Id);
                e.Property(x => x.FirstName).IsRequired().HasMaxLength(30).IsUnicode();
                e.Property(x => x.LastName).IsRequired().HasMaxLength(30).IsUnicode();
                e.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(15);
                e.HasIndex(x => x.PhoneNumber).IsUnique();
                e.Property(x => x.Email).IsRequired(false).HasMaxLength(60).IsUnicode(true);
                e.HasIndex(x => x.Email).IsUnique();
                e.Property(x => x.Age).IsRequired();
                e.ToTable(x => x.HasCheckConstraint("CK_Valid_Age_Client",
                    "[Age] > 16 AND [Age] < 110"));
                e.Property(x => x.Username).IsRequired().HasMaxLength(30).IsUnicode(true);
                e.HasIndex(x => x.Username).IsUnique();
            });

            modelBuilder.Entity<Service>(e =>
            {
                e.HasKey(x => x.Id);
                e.Property(x => x.Name).IsRequired().HasMaxLength(50).IsUnicode(true);
                e.Property(x => x.Price).IsRequired().HasColumnType("decimal(5, 2)");
                e.Property(x => x.Description).IsRequired().HasMaxLength(250).IsUnicode(true);
                e.Property(x => x.Duration).IsRequired();
                e.ToTable(x => x.HasCheckConstraint("CK_Valid_Duration", "[Duration] > 0"));
                e.Property(x => x.Category).HasConversion<string>();
            });

            modelBuilder.Entity<Employee>(e =>
            {
                e.HasKey(x => x.Id);
                e.Property(x => x.FirstName).IsRequired().HasMaxLength(30).IsUnicode();
                e.Property(x => x.LastName).IsRequired().HasMaxLength(30).IsUnicode();
                e.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(15);
                e.HasIndex(x => x.PhoneNumber).IsUnique();
                e.Property(x => x.Email).IsRequired(false).HasMaxLength(60).IsUnicode(true);
                e.HasIndex(x => x.Email).IsUnique();
                e.Property(x => x.Age).IsRequired();
                e.ToTable(x => x.HasCheckConstraint("CK_Valid_Age_Employee", 
                    "[Age] > AND [Age] < 110"));
                e.Property(x => x.Username).IsRequired().HasMaxLength(30).IsUnicode(true);
                e.HasIndex(x => x.Username).IsUnique();
                e.Property(x => x.Specialty).IsRequired().HasConversion<string>();
            });

            modelBuilder.Entity<Appointment>(e =>
            {
                e.HasKey(x => x.Id);
                e.Property(x => x.Time).IsRequired();
                e.HasOne(x => x.Client)
                    .WithMany(c => c.Appointments)
                    .HasForeignKey(x => x.ClientId)
                    .OnDelete(DeleteBehavior.Cascade);
                e.HasOne(x => x.Service)
                    .WithMany(s => s.Appointments)
                    .HasForeignKey(x => x.ServiceId)
                    .OnDelete(DeleteBehavior.Cascade);
                e.HasOne(x => x.Employee)
                    .WithMany(e => e.Appointments)
                    .HasForeignKey(x => x.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin1",
                    Password = "1234",
                    Role = Enums.RoleType.Admin
                });
        }
    }
}

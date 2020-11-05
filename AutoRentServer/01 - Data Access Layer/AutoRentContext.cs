using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BeardMan
{
    public partial class AutoRentContext : DbContext
    {
        public AutoRentContext()
        {
        }

        public AutoRentContext(DbContextOptions<AutoRentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adress> Adresses { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BranchesAdress> BranchesAdresses { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarType> CarTypes { get; set; }
        public virtual DbSet<CarsBranch> CarsBranches { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeesAdress> EmployeesAdresses { get; set; }
        public virtual DbSet<Home> Homes { get; set; }
        public virtual DbSet<Rent> Rents { get; set; }
        public virtual DbSet<RentsEmployee> RentsEmployees { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersAdress> UsersAdresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-161IG8J\\SQLEXPRESS;Database=AutoRent;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adress>(entity =>
            {
                entity.Property(e => e.AdressLine).HasMaxLength(50);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(15);

                entity.Property(e => e.Country).HasMaxLength(15);

                entity.Property(e => e.PostalZipCode).HasMaxLength(10);
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.Location).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<BranchesAdress>(entity =>
            {
                entity.HasKey(e => e.BranchAdressId);

                entity.HasOne(d => d.Adress)
                    .WithMany(p => p.BranchesAdresses)
                    .HasForeignKey(d => d.AdressId)
                    .HasConstraintName("FK_BranchesAdresses_Adresses");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BranchesAdresses)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_BranchesAdresses_Branches");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.Property(e => e.CarId).HasMaxLength(8);

                entity.HasOne(d => d.CarType)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.CarTypeId)
                    .HasConstraintName("FK_Cars_CarTypes");
            });

            modelBuilder.Entity<CarType>(entity =>
            {
                entity.Property(e => e.Gear).HasMaxLength(10);

                entity.Property(e => e.ImageFileName).HasMaxLength(1000);

                entity.Property(e => e.Manufacturer).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.PricePerDay).HasColumnType("money");

                entity.Property(e => e.PricePerDayLate).HasMaxLength(50);
            });

            modelBuilder.Entity<CarsBranch>(entity =>
            {
                entity.HasKey(e => e.CarBranchId);

                entity.Property(e => e.CarId).HasMaxLength(8);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.CarsBranches)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_CarsBranches_Branches");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.CarsBranches)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK_CarsBranches_Cars");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).HasMaxLength(10);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.JwtToken).HasMaxLength(1000);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Phone1).HasMaxLength(50);

                entity.Property(e => e.Phone2).HasMaxLength(50);

                entity.Property(e => e.Role).HasMaxLength(15);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeesAdress>(entity =>
            {
                entity.HasKey(e => e.EmployeeAdressId);

                entity.Property(e => e.EmployeeId).HasMaxLength(10);

                entity.HasOne(d => d.Adress)
                    .WithMany(p => p.EmployeesAdresses)
                    .HasForeignKey(d => d.AdressId)
                    .HasConstraintName("FK_EmployeesAdresses_Adresses");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeesAdresses)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_EmployeesAdresses_Employees");
            });

            modelBuilder.Entity<Home>(entity =>
            {
                entity.ToTable("Home");

                entity.Property(e => e.BackgroundImageFileName).HasMaxLength(1000);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FridayCloseHour).HasMaxLength(7);

                entity.Property(e => e.FridayOpenHour).HasMaxLength(7);

                entity.Property(e => e.HeaderText).HasMaxLength(200);

                entity.Property(e => e.MailingAdress).HasMaxLength(150);

                entity.Property(e => e.MainText).HasMaxLength(2000);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.SundayToThursdayCloseHour).HasMaxLength(7);

                entity.Property(e => e.SundayToThursdayOpenHour).HasMaxLength(7);
            });

            modelBuilder.Entity<Rent>(entity =>
            {
                entity.Property(e => e.CarId).HasMaxLength(8);

                entity.Property(e => e.PickupDate).HasColumnType("date");

                entity.Property(e => e.PracticalReturnDay).HasColumnType("date");

                entity.Property(e => e.ReturnDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasMaxLength(10);

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Rents)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK_Rents_Cars1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Rents)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Rents_Users");
            });

            modelBuilder.Entity<RentsEmployee>(entity =>
            {
                entity.HasKey(e => e.RentEmployeeId);

                entity.Property(e => e.EmployeeId).HasMaxLength(10);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.RentsEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_RentsEmployees_Employees");

                entity.HasOne(d => d.Rent)
                    .WithMany(p => p.RentsEmployees)
                    .HasForeignKey(d => d.RentId)
                    .HasConstraintName("FK_RentsEmployees_Rents");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasMaxLength(10);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.FirstName).HasMaxLength(15);

                entity.Property(e => e.Image).HasMaxLength(200);

                entity.Property(e => e.JwtToken).HasMaxLength(1000);

                entity.Property(e => e.LastName).HasMaxLength(15);

                entity.Property(e => e.Password).HasMaxLength(30);

                entity.Property(e => e.Sex).HasMaxLength(10);

                entity.Property(e => e.Username).HasMaxLength(20);
            });

            modelBuilder.Entity<UsersAdress>(entity =>
            {
                entity.HasKey(e => e.UserAdressId);

                entity.Property(e => e.UserId).HasMaxLength(10);

                entity.HasOne(d => d.Adress)
                    .WithMany(p => p.UsersAdresses)
                    .HasForeignKey(d => d.AdressId)
                    .HasConstraintName("FK_UsersAdresses_Adresses");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersAdresses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UsersAdresses_Users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

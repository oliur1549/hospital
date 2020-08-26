using HealthLab.Framework.AboutLab;
using HealthLab.Framework.AddressLab;
using HealthLab.Framework.AppointmentLab;
using HealthLab.Framework.BlogLab;
using HealthLab.Framework.ContactLab;
using HealthLab.Framework.DepartmentLab;
using HealthLab.Framework.DoctorLab;
using HealthLab.Framework.GalleryLab;
using HealthLab.Framework.LoginModel;
using HealthLab.Framework.ServiceLab;
using HealthLab.Framework.SettingLab;
using HealthLab.Framework.SlideShowLab;
using HealthLab.Framework.TimeLab;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework
{
    public class DatabaseContext : DbContext
    {
        private string _connectionString;
        private string _migrationAssemblyName;

        public DatabaseContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RoleAccount>()
                   .HasKey(pc => new { pc.RoleId, pc.AccountId });

            builder.Entity<RoleAccount>()
                .HasOne(d => d.Account)
                .WithMany(c => c.RoleAccounts)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleAccount_Account");

            builder.Entity<RoleAccount>()
                .HasOne(d => d.Role)
                .WithMany(c => c.RoleAccounts)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleAccount_Role");

            builder.Entity<AppointmentLab.Appointment>()
                .HasOne(p => p.Department)
                .WithMany(i => i.Appointments)
                .HasForeignKey(p => p.DepartmentId);

            builder.Entity<AppointmentLab.Appointment>()
                .HasOne(p => p.Doctor)
                .WithMany(i => i.Appointments)
                .HasForeignKey(p => p.DoctorId);

            builder.Entity<AppointmentLab.Appointment>()
                .HasOne(p => p.PreferredTime)
                .WithMany(i => i.Appointments)
                .HasForeignKey(p => p.TimeId);

            base.OnModelCreating(builder);
        }

        public DbSet<Service> services { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<PreferredTime> PreferredTimes { get; set; }
        public DbSet<SlideShow> SlideShows { get; set; }
        public DbSet<About> abouts { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<ContactInfo> Address { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleAccount> RoleAccounts { get; set; }
    }
}

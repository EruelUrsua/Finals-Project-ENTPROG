using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataModel
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=DESKTOP-JJNUTRM\\SQLEXPRESS;Database=Entprog_FinalProject;Integrated Security=sspi;TrustServerCertificate=true");
            //optionsBuilder.UseSqlServer("Server=laptop-TR5AJ4R0\\SQLEXPRESS;" +
            //  "Database=Entprog_Finals;Integrated Security=SSPI;" +
            //  "trustservercertificate=true");

            optionsBuilder.UseSqlServer("Server=desktop-1nft1om;" +
          "Database=Entprog_Finals; Integrated Security=SSPI;" +
          "TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Patient>().Property(p => p.Birthday).HasColumnType("date");

            //modelBuilder.Entity<Patient>().Ignore(p => p.Birthday);

            modelBuilder.Entity<Medical>().Property(p => p.Date).HasColumnType("datetime");
            modelBuilder.Entity<Medical>().Property(p => p.Vaccine).HasColumnType("Nvarchar(50)");
            modelBuilder.Entity<Medical>().Property(p => p.Location).HasColumnType("Nvarchar(200)");
            modelBuilder.Entity<Medical>().Property(p => p.Slots).HasColumnType("Int");
            modelBuilder.Entity<Medical>().Property(p => p.Time).HasColumnType("datetime");
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medical> Medicals { get; set; }
    }
}

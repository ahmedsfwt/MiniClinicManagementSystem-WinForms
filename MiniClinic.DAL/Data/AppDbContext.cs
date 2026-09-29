using Microsoft.EntityFrameworkCore;
using MiniClinic.DAL.Configurations;
using MiniClinic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniClinic.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-1BAK33G\SQLEXPRESS;Database=MiniClinicDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
        }

    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniClinic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniClinic.DAL.Configurations
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.AppointmentDate)
                .IsRequired();

            builder.Property(a => a.Notes)
                .HasMaxLength(500);

   
            builder.HasOne(a => a.Doctor)
                .WithMany()
                .HasForeignKey(a => a.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(a => a.Patient)
                .WithMany()
                .HasForeignKey(a => a.PatientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

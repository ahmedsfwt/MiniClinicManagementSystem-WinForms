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
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {            

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(d => d.Specialty)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}

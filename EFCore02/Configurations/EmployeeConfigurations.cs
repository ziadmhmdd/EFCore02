using EFCore02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {
           builder.HasKey(E => E.Id);
           builder.Property(E => E.Id).UseIdentityColumn(10, 10);
           builder.Property(E => E.Name)
                                           .HasColumnName("EmployeeName")
                                           .HasColumnType("Varchar")
                                           .HasMaxLength(50)
                                           .IsRequired();
            builder.Property(E => E.Salary).HasColumnType("decimal(18,2)").IsRequired(false);
        }
    }
}

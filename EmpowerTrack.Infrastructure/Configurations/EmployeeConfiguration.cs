using EmpowerTrack.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerTrack.Infrastructure.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<EmployeeEntity>
    {
        private const string _tableName = "tbl_employee_details";
        private string _schemaName;

        public EmployeeConfiguration(string schemaName) => _schemaName = schemaName;
        public void Configure(EntityTypeBuilder<EmployeeEntity> builder)
        {
            builder.ToTable(_tableName, _schemaName);
            builder.HasKey(e => e.EmployeeId);

            builder.HasOne(u => u.UserDb).WithOne(e => e.EmployeeDb).HasForeignKey<EmployeeEntity>(e => e.EmployeeUserId);
            builder.HasOne(r => r.RoleDb).WithMany(e => e.EmployeeDb).HasForeignKey(e => e.EmployeeRoleId).IsRequired();
        }
    }
}

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
    public class RoleConfiguration : IEntityTypeConfiguration<RoleEntity>
    {
        private const string _tableName = "tbl_roles";
        private string _schemaName;

        public RoleConfiguration(string schemaName) => _schemaName = schemaName;
        public void Configure(EntityTypeBuilder<RoleEntity> builder)
        {
            builder.ToTable(_tableName, _schemaName);
            builder.HasKey(b => b.RoleId);
        }
    }
}

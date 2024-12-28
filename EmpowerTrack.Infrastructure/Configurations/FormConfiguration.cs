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
    public class FormConfiguration : IEntityTypeConfiguration<FormEntity>
    {
        private const string _tableName = "tbl_forms";
        private string _schemaName;

        public FormConfiguration(string schemaName) => _schemaName = schemaName;
        public void Configure(EntityTypeBuilder<FormEntity> builder)
        {
            builder.ToTable(_tableName, _schemaName);
            builder.HasKey(b => b.FormId);

            builder.HasOne(m=>m.MainModuleEntity).WithMany(f=>f.Forms).HasForeignKey(f=>f.FormModuleId);
        }
    }
}

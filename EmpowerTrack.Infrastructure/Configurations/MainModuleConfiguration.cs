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
    public class MainModuleConfiguration : IEntityTypeConfiguration<MainModuleEntity>
    {
        private const string _tableName = "tbl_main_modules";
        private string _schemaName;

        public MainModuleConfiguration(string schemaName) => _schemaName = schemaName;
        public void Configure(EntityTypeBuilder<MainModuleEntity> builder)
        {
            builder.ToTable(_tableName, _schemaName);
            builder.HasKey(b => b.ModuleId);
        }
    }
}

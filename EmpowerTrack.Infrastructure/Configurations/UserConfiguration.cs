using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpowerTrack.Core.Entities;

namespace EmpowerTrack.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        private const string _tableName = "tbl_users";
        private string _schemaName;

        public UserConfiguration(string schemaName) => _schemaName = schemaName;
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable(_tableName, _schemaName);
            builder.HasKey(b => b.UserId);
        }
    }
}

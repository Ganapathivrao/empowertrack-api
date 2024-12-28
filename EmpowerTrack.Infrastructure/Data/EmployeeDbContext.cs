using EmpowerTrack.Core.Entities;
using EmpowerTrack.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmpowerTrack.Infrastructure.Data
{
    public class EmployeeDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionStringNpg;

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
            _connectionStringNpg = _configuration["ConnectionStrings:PostgreSqlConnString"];
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            int commandTimeout = int.Parse(_configuration.GetSection("APIDBContext:CommandTimeout").Value);
            optionsBuilder.UseNpgsql(_connectionStringNpg, options => options.CommandTimeout(commandTimeout))
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
            optionsBuilder.EnableSensitiveDataLogging(true);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string schemaNme = _configuration["APIDBContext:SchemaName"];
            modelBuilder.ApplyConfiguration(new UserConfiguration(schemaNme));
            modelBuilder.ApplyConfiguration(new RoleConfiguration(schemaNme));
            modelBuilder.ApplyConfiguration(new MainModuleConfiguration(schemaNme));
            modelBuilder.ApplyConfiguration(new FormConfiguration(schemaNme));
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration(schemaNme));

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<UserEntity> UsersDbType { get; set; }
        public DbSet<RoleEntity> RoleDbType { get; set; }
        public DbSet<MainModuleEntity> MainModuleDbType { get; set; }
        public DbSet<FormEntity> FormDbType { get; set; }
        public DbSet<EmployeeEntity> EmployeeDbType { get; set; }

    }
}

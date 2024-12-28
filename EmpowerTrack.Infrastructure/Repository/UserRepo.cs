using EmpowerTrack.Core.Dto;
using EmpowerTrack.Core.Entities;
using EmpowerTrack.Core.RepoInterfaces;
using EmpowerTrack.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerTrack.Infrastructure.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly EmployeeDbContext _dbcontext;
        public UserRepo(EmployeeDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<UserEntity> ValidateCredAsync(UserEntity user)
        {

            return await _dbcontext.UsersDbType.Include(u => u.EmployeeDb).ThenInclude(e=>e.RoleDb).Where(u => u.UserName == user.UserName).FirstOrDefaultAsync();
        }
    }
}

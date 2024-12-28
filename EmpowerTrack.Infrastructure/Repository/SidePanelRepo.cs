using EmpowerTrack.Core.Dto;
using EmpowerTrack.Core.Entities;
using EmpowerTrack.Core.RepoInterfaces;
using EmpowerTrack.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerTrack.Infrastructure.Repository
{
    public class SidePanelRepo : ISidePanelRepo
    {
        private readonly EmployeeDbContext _dbcontext;
        public SidePanelRepo(EmployeeDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<ICollection<MainModuleEntity>> GetModuleDetailsAsync()
        {
            return await _dbcontext.MainModuleDbType.Include(form => form.Forms).ToListAsync();
        }
    }
}

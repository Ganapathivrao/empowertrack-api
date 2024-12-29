using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerTrack.Core.Dto.Read
{
    public class EmployeeReadDto
    {
        public int EmployeeId { get; set; }

        public string? EmployeeName { get; set; }

        public int EmployeeUserId { get; set; }

        public int EmployeeRoleId { get; set; }

        public RoleReadDto? Role { get; set; }

        public UserReadDto? User { get; set; }

    }
}

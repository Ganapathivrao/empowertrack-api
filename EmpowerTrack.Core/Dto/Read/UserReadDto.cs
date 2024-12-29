using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerTrack.Core.Dto.Read
{
    public class UserReadDto
    {
        public int UserId { get; set; }

        public string? UserName { get; set; }

        public string? UserPasswordHash { get; set; }

        public EmployeeReadDto? Employee { get; set; }
    }
}

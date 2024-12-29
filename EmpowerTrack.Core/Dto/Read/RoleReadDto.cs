using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerTrack.Core.Dto.Read
{
    public class RoleReadDto
    {

        public int RoleId { get; set; }

        public string? RoleName { get; set; }
    }
}

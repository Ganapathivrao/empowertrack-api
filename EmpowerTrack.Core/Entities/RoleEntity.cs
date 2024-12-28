using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerTrack.Core.Entities
{
    public class RoleEntity
    {
        [Column("role_id")]
        public int RoleId { get; set; }

        [Column("role_name")]
        public string? RoleName { get; set; }

        public ICollection<EmployeeEntity>? EmployeeDb { get; set; }
    }
}

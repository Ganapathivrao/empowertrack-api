using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerTrack.Core.Entities
{
    public class UserEntity
    {
        [Key]
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("user_name")]
        public string? UserName { get; set; }

        [Column("user_passwordhash")]
        public string? UserPasswordHash { get; set; }

        public EmployeeEntity? EmployeeDb { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerTrack.Core.Entities
{

    public class EmployeeEntity
    {
        [Key]
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Column("employee_user_id")]
        public int EmployeeUserId { get; set; }

        [Column("employee_name")]
        public string? EmployeeName { get; set; }

        [Column("employee_dob")]
        public DateTime EmployeeDob { get; set; }

        [Column("employee_gender")]
        public string? EmployeeGender { get; set; }

        [Column("employee_phone_number")]
        public string? EmployeePhoneNumber { get; set; }

        [Column("employee_email_address")]
        public string? EmployeeEmailAddress { get; set; }

        [Column("employee_role_id")]
        public int EmployeeRoleId { get; set; }

        [Column("employee_status")]
        public int EmployeeStatus { get; set; }

        [ForeignKey("EmployeeUserId")]
        public UserEntity? UserDb { get; set; }

        [ForeignKey("EmployeeRoleId")]
        public RoleEntity? RoleDb { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerTrack.Core.Entities
{
    public class FormEntity
    {
        [Column("form_id")]
        public int FormId { get; set; }

        [Column("form_name")]
        public string? FormName { get; set; }

        [Column("form_module_id")]
        public int FormModuleId { get; set; }

        public MainModuleEntity? MainModuleEntity { get; set; }
    }
}

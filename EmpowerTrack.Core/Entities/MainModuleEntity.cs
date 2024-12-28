using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerTrack.Core.Entities
{
    public class MainModuleEntity
    {
        [Column("module_id")]
        public int ModuleId { get; set; }

        [Column("module_name")]
        public string? ModuleName { get; set; }

        public ICollection<FormEntity>? Forms { get; set; }
    }
}

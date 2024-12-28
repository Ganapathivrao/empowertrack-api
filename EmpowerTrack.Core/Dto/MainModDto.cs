using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerTrack.Core.Dto
{
    public class MainModDto
    {
        public int ModuleId { get; set; }

        public string? ModuleName { get; set; }

        public ICollection<FormDto>? Forms { get; set; }
    }
}

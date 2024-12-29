

namespace EmpowerTrack.Core.Dto.Read
{
    public class MainModReadDto
    {
        public int ModuleId { get; set; }

        public string? ModuleName { get; set; }

        public ICollection<FormReadDto>? Forms { get; set; }
    }
}

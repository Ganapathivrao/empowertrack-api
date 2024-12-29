using EmpowerTrack.Application.Response;
using EmpowerTrack.Core.Dto.Read;

namespace EmpowerTrack.Application.ServiceInterfaces
{
    public interface ISidePanelService
    {
        Task<ApiResponse<ICollection<MainModReadDto>>> GetModuleDetailsAsync();
    }
}

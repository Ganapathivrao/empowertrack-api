using EmpowerTrack.Application.Response;
using EmpowerTrack.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerTrack.Application.ServiceInterfaces
{
    public interface ISidePanelService
    {
        Task<ApiResponse<ICollection<MainModDto>>> GetModuleDetailsAsync();
    }
}

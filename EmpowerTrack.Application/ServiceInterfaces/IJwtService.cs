using EmpowerTrack.Core.Dto.Read;
using EmpowerTrack.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerTrack.Application.ServiceInterfaces
{
    public interface IJwtService
    {
        Task<string> GetJwtToken(UserReadDto user);
    }
}

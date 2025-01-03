﻿using EmpowerTrack.Application.Response;
using EmpowerTrack.Core.Dto.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerTrack.Application.ServiceInterfaces
{
    public interface IUserService
    {
        Task<ApiResponse<bool>> ValidateCredentialsAsync(UserReadDto user);
    }
}

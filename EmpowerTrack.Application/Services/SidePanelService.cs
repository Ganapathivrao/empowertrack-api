﻿using AutoMapper;
using EmpowerTrack.Application.Response;
using EmpowerTrack.Application.ServiceInterfaces;
using EmpowerTrack.Core.Dto;
using EmpowerTrack.Core.Enums;
using EmpowerTrack.Core.RepoInterfaces;

namespace EmpowerTrack.Application.Services
{
    public class SidePanelService:ISidePanelService
    {
        private readonly ISidePanelRepo _repo;
        private readonly IMapper _mapper;
        public SidePanelService(ISidePanelRepo repo,IMapper mapper) 
        { 
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<ApiResponse<ICollection<MainModDto>>> GetModuleDetailsAsync()
        {
            var mainModuleEntities = await _repo.GetModuleDetailsAsync();
            if(!mainModuleEntities.Any())
            {
                return new ApiResponse<ICollection<MainModDto>>
                {
                    Status = (int)ResponseStatus.Failure,
                    Message = ResponseMessage.DataFailedToRetrieve.GetDescription(),
                    Data=null
                };
            }

            var mainModuleDto= _mapper.Map<ICollection<MainModDto>>(mainModuleEntities);

            return new ApiResponse<ICollection<MainModDto>>
            {
                Status = (int)ResponseStatus.Success,
                Message = ResponseMessage.DataRetrievedSuccessfully.GetDescription(),
                Data=mainModuleDto
            };
        }
    }
}
using AutoMapper;
using EmpowerTrack.Application.Response;
using EmpowerTrack.Application.ServiceInterfaces;
using EmpowerTrack.Core.Dto;
using EmpowerTrack.Core.Dto.Read;
using EmpowerTrack.Core.Entities;
using EmpowerTrack.Core.Enums;
using EmpowerTrack.Core.RepoInterfaces;
using Microsoft.AspNetCore.Http;

namespace EmpowerTrack.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;
        private readonly IJwtService _jwtService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public UserService(IUserRepo userRepo, IJwtService jwtService, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _userRepo = userRepo;
            _jwtService = jwtService;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        public async Task<ApiResponse<bool>> ValidateCredentialsAsync(UserReadDto user)
        {
            ValidationObjDto valObj = new ValidationObjDto();
            var userEtity = _mapper.Map<UserEntity>(user);
            var userDto = await _userRepo.ValidateCredAsync(userEtity);
            if (userDto == null)
            {
                return new ApiResponse<bool>
                {
                    Status = (int)ResponseStatus.Failure,
                    Message = ResponseMessage.UserNameWrong.GetDescription(),
                    Data = false
                };
            }
            var userRead = _mapper.Map<UserReadDto>(userDto);

            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(user.UserPasswordHash, userRead.UserPasswordHash);

            if (!isPasswordValid)
            {
                return new ApiResponse<bool>
                {
                    Status = (int)ResponseStatus.Failure,
                    Message = ResponseMessage.PasswordWrong.GetDescription(),
                    Data = false
                };
            }

            var jwtToken = await _jwtService.GetJwtToken(userRead);
            if (jwtToken == null)
            {
                return new ApiResponse<bool>
                {
                    Status = (int)ResponseStatus.Failure,
                    Message = "Token Not generated",
                    Data = false
                };
            }

            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Secure = false,
                SameSite = SameSiteMode.Lax,
                Expires = DateTime.UtcNow.AddMinutes(20)
            };

            _httpContextAccessor.HttpContext.Response.Cookies.Append("authToken", jwtToken, cookieOptions);

            return new ApiResponse<bool>
            {
                Status = (int)ResponseStatus.Success,
                Message = ResponseMessage.LoginSuccess.GetDescription(),
                Data = true
            };

        }
    }
}

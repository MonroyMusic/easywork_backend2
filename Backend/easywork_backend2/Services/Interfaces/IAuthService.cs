﻿using easywork_backend.Dtos;
using easywork_backend.Dtos.Security;

namespace easywork_backend2.Services.Interfaces
{
    public interface IAuthService
    {
        Task<ResponseDto<LoginResponseDto>> LoginAsync(LoginDto dto);
        Task<ResponseDto<LoginResponseDto>> RefreshTokenAsync();
    }
}
using SMM.Application.Auth.DTOs;
using SMM.Domain.Entities;

namespace SSM.API.Helpers
{
    public interface IAuthHelper
    {
        Task<AuthResponse> CreateAuthResponseAsync(AppUser user);
    }
}

using SMM.Domain.Entities;

namespace SMM.Application.Auth.Interfaces;

public interface ITokenService
{
    Task<(string Token, DateTime ExpiresAt)>
        CreateAccessTokenAsync(AppUser user);

    (string Token, DateTime ExpiresAt)
        CreateRefreshToken();
}
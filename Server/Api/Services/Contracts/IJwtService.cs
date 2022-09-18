using MyCompany.MyApp.Server.Api.Models.Account;
using MyCompany.MyApp.Shared.Dtos.Account;

namespace MyCompany.MyApp.Server.Api.Services.Contracts;

public interface IJwtService
{
    Task<SignInResponseDto> GenerateToken(User user);
}

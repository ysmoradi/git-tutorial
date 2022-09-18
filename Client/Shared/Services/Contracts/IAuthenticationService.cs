using MyCompany.MyApp.Shared.Dtos.Account;

namespace MyCompany.MyApp.Client.Shared.Services.Contracts;

public interface IAuthenticationService
{
    Task SignIn(SignInRequestDto dto);

    Task SignOut();
}

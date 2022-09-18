namespace MyCompany.MyApp.Shared.Services.Contracts;

public interface IAuthTokenProvider
{
    Task<string?> GetAcccessToken();
}

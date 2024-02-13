using ErtegaEducationApi.Models;

namespace ErtegaEducationApi.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterUser(RegisterModel registerModel);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
    }
}

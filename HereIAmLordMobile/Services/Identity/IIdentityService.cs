using System.Threading.Tasks;
using HereIAmLordMobile.Models.Token;

namespace HereIAmLordMobile.Services.Identity
{
    public interface IIdentityService
    { 
        string CreateAuthorizationRequest();
        string CreateLogoutRequest(string token);
        Task<UserToken> GetTokenAsync(string code);

    }
}

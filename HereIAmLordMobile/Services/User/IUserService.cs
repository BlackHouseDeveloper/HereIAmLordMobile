using System.Threading.Tasks;
using HereIAmLordMobile.Models.User;


namespace HereIAmLordMobile.Services.User
{
    public interface IUserService
    {
        Task<UserInfo> GetUserInfoAsync(string authToken);
    }
}

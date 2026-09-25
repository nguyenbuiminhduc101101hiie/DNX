using DNX.Models;
using DNX.Response;

namespace DNX.Interface
{
    public interface IUserService
    {
        Task<LoginResponse> SignInAsync(string userCredential);
    }
}

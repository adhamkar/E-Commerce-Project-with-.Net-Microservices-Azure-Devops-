using E_Commerce.Core.DTOs;

namespace E_Commerce.Core.ServiceContracts.Interfaces.UserSerice
{
    public interface IUserService
    {
        Task<UserAuthentificationResponse?> Login(UserLogin loginRequest);
        Task<UserAuthentificationResponse?> Register(UserRegisterRequest registerRequest);
    }
}

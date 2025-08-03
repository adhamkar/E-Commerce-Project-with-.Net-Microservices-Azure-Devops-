using AutoMapper;
using E_Commerce.Core.DTOs;
using E_Commerce.Core.Entities;
using E_Commerce.Core.RepositoryContracts.Interfaces.UserRepo;
using E_Commerce.Core.ServiceContracts.Interfaces.UserSerice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Services.Implementations.UserService
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository,IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<UserAuthentificationResponse?> Login(UserLogin loginRequest)
        {
            User? user=await _userRepository.FindUserbyEmailAndPassword(loginRequest.Email,loginRequest.Password);
            if (user == null) return null;
            //return new UserAuthentificationResponse(
            //    user.UserID,user.Email,
            //    user.Password,user.PersonName,
            //    user.Gender.ToString(), "token", Success: true);
            return _mapper.Map<UserAuthentificationResponse>(user) with
            {
                Success = true, Token="token"
            };
        }

        public async Task<UserAuthentificationResponse?> Register(UserRegisterRequest registerRequest)
        {
            //User? user = new User() {
            //    Email=registerRequest.Email,
            //    PersonName=registerRequest.PersonName,
            //    Password=registerRequest.Password,
            //    Gender=registerRequest.Gender};
            User? user = _mapper.Map<User>(registerRequest);

            User? userToRegister=await _userRepository.AddUser(user);
            
            if (userToRegister == null) return null;

            //return new UserAuthentificationResponse(
            //    userToRegister.UserID, userToRegister.Email,
            //    userToRegister.Password, userToRegister.PersonName,
            //    userToRegister.Gender.ToString(), "token", Success: true);
            return _mapper.Map<UserAuthentificationResponse>(userToRegister) with
            {
                Success = true,
                Token = "token"
            };

        }
    }
}

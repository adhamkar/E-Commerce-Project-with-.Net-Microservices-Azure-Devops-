using E_Commerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.RepositoryContracts.Interfaces.UserRepo
{
    public interface IUserRepository
    {
        Task<User?> AddUser(User user);
        Task<User?> FindUserbyEmailAndPassword(string? Email, string? Password);
    }
}

using Dapper;
using E_Commerce.Core.Entities;
using E_Commerce.Core.RepositoryContracts.Interfaces.UserRepo;
using E_Commerce.Infrastructure.DbContexte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Repositories.Implementations.UserRepo;

internal class UserRepository : IUserRepository
{
    private readonly DapperDbContext _dbContext;
    public UserRepository(DapperDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<User?> AddUser(User user)
    {
        user.UserID = Guid.NewGuid();
        //sql query to inject data to users DB
        string query = "INSERT INTO PUBLIC.\"USERS\"(\"UserID\", \"Email\", \"PersonName\", \"Password\", \"Gender\") " +
               "VALUES(@UserID, @Email, @PersonName, @Password, @Gender)";


        int rows = await _dbContext.DbConnection.ExecuteAsync(query, user);
        if (rows > 0) return user;
        else return null;
    }

    public async Task<User?> FindUserbyEmailAndPassword(string? Email, string? Password)
    {
        //Sql Query to select/retrieve user from DB 
        string query = "SELECT * FROM PUBLIC.\"USERS\" WHERE \"Email\"=@Email AND \"Password\"=@Password";
        var param= new { Email = Email,Password=Password };
        User? user=await _dbContext.DbConnection.QueryFirstOrDefaultAsync<User>(query,param);
        return user;
    }
}

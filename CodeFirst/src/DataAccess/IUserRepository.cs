using System;
using System.Linq;
using System.Threading.Tasks;
using Example.Abstractions;

namespace Example.DataAccess
{
    public interface IUserRepository
    {
        Task<User?> GetUserAsync(Guid userId);
        IQueryable<User> GetUsers();
        Task<User> UpsertUserAsync(User user);
    }
}

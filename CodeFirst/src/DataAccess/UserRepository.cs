using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Abstractions;

namespace Example.DataAccess
{
    public class UserRepository : IUserRepository
    {
        public Dictionary<Guid, User> _users = new User[] {
            new User(Guid.Parse("1a04e0c4-858e-486b-aa56-1e251bce454b"), "sepa", "Pascal", "Senn"),
            new User(Guid.Parse("46c2a5f5-cb76-43e7-89a3-f33b690e9c40"), "sasa", "Sam", "Sampleman"),
            new User(Guid.Parse("738160ae-4c67-48e5-a64f-66199c3afe7b"), "luga", "Gabriel", "Lucaci"),
        }.ToDictionary(x => x.Id);

        public IQueryable<User> GetUsers() => _users.Values.AsQueryable();

        public Task<User> UpsertUserAsync(User user)
        {
            _users[user.Id] = user;
            return Task.FromResult(user);
        }

        public Task<User?> GetUserAsync(Guid userId)
        {
            if (_users.TryGetValue(userId, out User? user))
            {
                return Task.FromResult<User?>(user);
            }
            return Task.FromResult<User?>(null);
        }
    }
}

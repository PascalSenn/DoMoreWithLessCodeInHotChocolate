using System;
using System.Linq;
using Example.Abstractions;
using Example.DataAccess;
using System.Threading.Tasks;
using HotChocolate;

namespace Example.Graphql
{
    public class Query
    {
        public IQueryable<User> GetUsers(
            [Service] IUserRepository userRepository)
        {
            return userRepository.GetUsers();
        }

        public Task<User> GetUser(
            [Service] IUserRepository userRepository,
            Guid userId)
        {
            return userRepository.GetUserAsync(userId);
        }

        public IQueryable<Booking> GetBookings(
            [Service] IBookingsRepository bookingsRepository)
        {
            return bookingsRepository.GetBookings();
        }
    }
}
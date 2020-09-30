using System.Collections.Generic;
using System.Linq;
using Example.Abstractions;
using Example.DataAccess;
using HotChocolate;
using HotChocolate.Types;

namespace Example.Graphql
{
    [ExtendObjectType(nameof(User))]
    public class UserTypeExtension
    {
        public List<Booking> GetBookings(
            [Parent] User user,
            [Service] IBookingsRepository repository)
        {
            return repository
                .GetBookings()
                .Where(b => b.UserId == user.Id)
                .ToList();
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Example.Abstractions;
using Example.DataAccess;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;

namespace Example.Graphql
{
    [ExtendObjectType(nameof(User))]
    public class UserTypeExtension
    {
        public List<Booking> GetBookings(
            [Service] IBookingsRepository repository,
            [Parent] User user)
        {
            return repository
                    .GetBookings()
                    .Where(b => b.UserId == user.Id)
                    .ToList();
        }
    }
}
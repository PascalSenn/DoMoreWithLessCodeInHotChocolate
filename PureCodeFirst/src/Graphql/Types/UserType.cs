using System.Linq;
using Example.Abstractions;
using Example.DataAccess;
using HotChocolate.Types;

namespace Example.Graphql
{
    public class UserType : ObjectType<User>
    {
        private IBookingsRepository _repository;

        public UserType(IBookingsRepository repository)
        {
            _repository = repository;
        }

        protected override void Configure(IObjectTypeDescriptor<User> descriptor)
        {
            descriptor.Name("User");

            descriptor.Field(x => x.Id).Type<NonNullType<IdType>>();
            descriptor.Field(x => x.Name).Type<NonNullType<StringType>>();
            descriptor.Field(x => x.Surname).Type<NonNullType<StringType>>();
            descriptor.Field(x => x.UserName).Type<NonNullType<StringType>>();
            descriptor.Field("bookings")
                .Type<NonNullType<ListType<NonNullType<BookingType>>>>()
                .Resolve(x => _repository
                    .GetBookings()
                    .Where(b => b.UserId == x.Parent<User>().Id)
                    .ToList());
        }
    }
}
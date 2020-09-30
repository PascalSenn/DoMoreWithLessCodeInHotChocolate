using HotChocolate.Types;

namespace Example.Graphql
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Name("Query");

            descriptor.Field(x => x.GetUsers())
                .Type<NonNullType<ListType<NonNullType<UserType>>>>();

            descriptor.Field(x => x.GetBookings())
                .Type<NonNullType<ListType<NonNullType<BookingType>>>>();
        }
    }
}
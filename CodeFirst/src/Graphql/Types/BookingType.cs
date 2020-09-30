using Example.Abstractions;
using HotChocolate.Types;

namespace Example.Graphql
{
    public class BookingType : ObjectType<Booking>
    {
        protected override void Configure(IObjectTypeDescriptor<Booking> descriptor)
        {
            descriptor.Name("Booking");

            descriptor.Field(x => x.Id).Type<NonNullType<IdType>>();
            descriptor.Field(x => x.UserId).Ignore();
            descriptor.Field(x => x.Date).Type<NonNullType<StringType>>();
        }
    }
}
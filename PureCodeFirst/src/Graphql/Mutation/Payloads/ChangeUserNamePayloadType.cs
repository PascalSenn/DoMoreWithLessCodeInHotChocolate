using HotChocolate.Types;

namespace Example.Graphql
{
    public class ChangeUserNamePayloadType : ObjectType<ChangeUserNamePayload>
    {
        protected override void Configure(
            IObjectTypeDescriptor<ChangeUserNamePayload> descriptor)
        {
            descriptor.Name("ChangeUserNamePayload");

            descriptor.Field(x => x.User)
                .Name("user")
                .Type<NonNullType<UserType>>();
        }
    }
}
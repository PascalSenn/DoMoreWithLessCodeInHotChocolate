using HotChocolate.Types;

namespace Example.Graphql
{
    public class MutationType : ObjectType<Mutation>
    {
        protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
        {
            descriptor.Name("Mutation");

            descriptor.Field(x => x.ChangeUserNameAsync(default!))
                .Name("changeUserName")
                .Argument("input", x => x.Type<NonNullType<ChangeUserNameInputType>>())
                .Type<NonNullType<ListType<NonNullType<ChangeUserNamePayloadType>>>>();
        }
    }
}
using HotChocolate.Types;

namespace Example.Graphql
{
    public class ChangeUserNameInputType : InputObjectType<ChangeUserNameInput>
    {
        protected override void Configure(
            IInputObjectTypeDescriptor<ChangeUserNameInput> descriptor)
        {
            descriptor.Name("ChangeUserNameInput");
            descriptor.Field(x => x.UserId)
                .Name("userId")
                .Type<NonNullType<IdType>>();

            descriptor.Field(x => x.UserName)
                .Name("userName")
                .Type<NonNullType<StringType>>();
        }
    }
}
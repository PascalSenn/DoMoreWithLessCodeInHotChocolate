using System;
using HotChocolate;
using HotChocolate.Types;

namespace Example.Graphql
{
    public class ChangeUserNameInput
    {
        public ChangeUserNameInput(
            Guid userId,
            string userName)
        {
            UserId = userId;
            UserName = userName;
        }

        [GraphQLType(typeof(IdType))]
        public Guid UserId { get; }

        public string UserName { get; }
    }
}
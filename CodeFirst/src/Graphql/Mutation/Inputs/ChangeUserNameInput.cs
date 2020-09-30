using System;

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

        public Guid UserId { get; }

        public string UserName { get; }
    }
}
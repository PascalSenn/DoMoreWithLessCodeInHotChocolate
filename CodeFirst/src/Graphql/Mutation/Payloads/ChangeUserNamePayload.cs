using Example.Abstractions;

namespace Example.Graphql
{
    public class ChangeUserNamePayload
    {
        public ChangeUserNamePayload(User user)
        {
            User = user;
        }

        public User User { get; }
    }
}
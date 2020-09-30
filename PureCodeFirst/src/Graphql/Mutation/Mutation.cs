using System.Threading.Tasks;
using Example.DataAccess;
using HotChocolate;

namespace Example.Graphql
{
    public class Mutation
    {
        public async Task<ChangeUserNamePayload> ChangeUserNameAsync(
            [Service] IUserRepository userRepository,
            ChangeUserNameInput input)
        {
            var user = await userRepository.GetUserAsync(input.UserId);

            return new ChangeUserNamePayload(user);
        }
    }
}
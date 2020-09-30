using System.Threading.Tasks;
using Example.DataAccess;

namespace Example.Graphql
{
    public class Mutation
    {
        private readonly IUserRepository _userRepository;

        public Mutation(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ChangeUserNamePayload> ChangeUserNameAsync(
            ChangeUserNameInput input)
        {
            var user = await _userRepository.GetUserAsync(input.UserId);

            return new ChangeUserNamePayload(user);
        }
    }
}
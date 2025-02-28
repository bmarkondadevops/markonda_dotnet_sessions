namespace LoginCustomValidation.Services
{
    public class UserService : IUserService
    {
        // Mock implementation for demonstration purposes.
        private readonly List<string> _usernames = new List<string> { "admin", "user1", "user2" };

        public bool IsUsernameAvailable(string username)
        {
            return !_usernames.Contains(username);
        }
    }

}

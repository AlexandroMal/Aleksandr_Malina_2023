using WebAuthentication.Models;

namespace WebAuthentication.Data
{
    public class Users
    {
        private List<UserModel> users = new List<UserModel>();

        public Users()
        {
            users.Add(new UserModel
            {
                id = Guid.NewGuid(),
                username = "sasha",
                password = "12345",
                admin = true
            });

            users.Add(new UserModel
            {
                id = Guid.NewGuid(),
                username = "anton",
                password = "qwerty",
                admin = false
            });
        }

        public UserModel UserValidation(string name, string password)
        {
            return users.FirstOrDefault(u => u.username == name && u.password == password, null);

        }
    }
}

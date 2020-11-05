using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeardMan
{
    public class UsersLogic : BaseLogic
    {
        public UsersLogic(AutoRentContext db) : base(db) { }

        public List<UserModel> GetAllUsers()
        {
            return DB.Users.Select(p => new UserModel(p)).ToList();
        }







        public bool isUserNameExists(string userName)
        {
            return DB.Users.Any(u => u.Username == userName);
        }

        public UserModel GetUsersByCredentials(CredentialsModel credentialsModel)
        {
            return new UserModel(DB.Users.SingleOrDefault(u => u.Username == credentialsModel.Username && u.Password == credentialsModel.Password));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BeardMan
{
    public class UserModel
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string JwtToken { get; set; }
        public string Image { get; set; }

        public UserModel(User user)
        {
            UserId = user.UserId;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Sex = user.Sex;
            BirthDate = user.BirthDate;
            Email = user.Email;
            Username = user.Username;
            Password = user.Password;
            JwtToken = user.JwtToken;
            Image = user.Image;
        }
    }
}

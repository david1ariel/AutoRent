﻿using System;
using System.Collections.Generic;

namespace BeardMan
{
    public partial class User
    {
        public User()
        {
            Rents = new HashSet<Rent>();
            UsersAdresses = new HashSet<UsersAdress>();
        }

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

        public virtual ICollection<Rent> Rents { get; set; }
        public virtual ICollection<UsersAdress> UsersAdresses { get; set; }
    }
}

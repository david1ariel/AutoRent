using System;
using System.Collections.Generic;
using System.Text;

namespace BeardMan
{
    public class EmployeeModel
    {
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Adress { get; set; }
        public string JwtToken { get; set; }
        public string Role { get; set; }


        public EmployeeModel(Employee employee)
        {
            EmployeeId = employee.EmployeeId;
            FirstName = employee.FirstName;
            LastName = employee.LastName;
            BirthDate = employee.BirthDate;
            HireDate = employee.HireDate;
            Email = employee.Email;
            Username = employee.Username;
            Password = employee.Password;
            Phone1 = employee.Phone1;
            Phone2 = employee.Phone2;
            JwtToken = employee.JwtToken;
            Role = employee.Role;
        }
    }
}

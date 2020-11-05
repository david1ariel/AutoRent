using System;
using System.Collections.Generic;

namespace BeardMan
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeesAdresses = new HashSet<EmployeesAdress>();
            RentsEmployees = new HashSet<RentsEmployee>();
        }

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
        public string JwtToken { get; set; }
        public string Role { get; set; }

        public virtual ICollection<EmployeesAdress> EmployeesAdresses { get; set; }
        public virtual ICollection<RentsEmployee> RentsEmployees { get; set; }
    }
}

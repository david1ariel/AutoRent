using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeardMan
{
    public class EmployeesLogic : BaseLogic
    {
        public EmployeesLogic(AutoRentContext db) : base(db) { }

        public List<EmployeeModel> GetAllEmployees()
        {
            return DB.Employees.Select(p => new EmployeeModel(p)).ToList();
        }
    }
}

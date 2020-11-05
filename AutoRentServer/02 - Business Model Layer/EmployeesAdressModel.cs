using System;
using System.Collections.Generic;
using System.Text;

namespace BeardMan
{
    class EmployeesAdressModel
    {
        public int EmployeeAdressId { get; set; }
        public string EmployeeId { get; set; }
        public int? AdressId { get; set; }

        public EmployeesAdressModel( EmployeesAdress employeesAdress)
        {
            EmployeeAdressId = employeesAdress.EmployeeAdressId;
            EmployeeId = employeesAdress.EmployeeId;
            AdressId = employeesAdress.AdressId;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BeardMan
{
    class RentsEmployeeModel
    {
        public int RentEmployeeId { get; set; }
        public int? RentId { get; set; }
        public string EmployeeId { get; set; }

        public RentsEmployeeModel( RentsEmployee rentsEmployee)
        {
            RentEmployeeId = rentsEmployee.RentEmployeeId;
            RentId = rentsEmployee.RentId;
            EmployeeId = rentsEmployee.EmployeeId;
        }
    }
}

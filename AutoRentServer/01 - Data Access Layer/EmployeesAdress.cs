using System;
using System.Collections.Generic;

namespace BeardMan
{
    public partial class EmployeesAdress
    {
        public int EmployeeAdressId { get; set; }
        public string EmployeeId { get; set; }
        public int? AdressId { get; set; }

        public virtual Adress Adress { get; set; }
        public virtual Employee Employee { get; set; }
    }
}

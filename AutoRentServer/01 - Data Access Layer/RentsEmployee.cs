using System;
using System.Collections.Generic;

namespace BeardMan
{
    public partial class RentsEmployee
    {
        public int RentEmployeeId { get; set; }
        public int? RentId { get; set; }
        public string EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Rent Rent { get; set; }
    }
}

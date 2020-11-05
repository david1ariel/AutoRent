using System;
using System.Collections.Generic;

namespace BeardMan
{
    public partial class Rent
    {
        public Rent()
        {
            RentsEmployees = new HashSet<RentsEmployee>();
        }

        public int RentId { get; set; }
        public DateTime? PickupDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? PracticalReturnDay { get; set; }
        public string UserId { get; set; }
        public string CarId { get; set; }

        public virtual Car Car { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<RentsEmployee> RentsEmployees { get; set; }
    }
}

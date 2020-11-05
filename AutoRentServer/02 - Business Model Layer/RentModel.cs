using System;
using System.Collections.Generic;
using System.Text;

namespace BeardMan
{
    public class RentModel
    {
        public int RentId { get; set; }
        public DateTime? PickupDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? PracticalReturnDay { get; set; }
        public string UserId { get; set; }
        public string CarId { get; set; }

       
        public RentModel(Rent rent) { 
            RentId = rent.RentId;
            PickupDate = rent.PickupDate;
            ReturnDate = rent.ReturnDate;
            PracticalReturnDay = rent.PracticalReturnDay;
            UserId = rent.UserId;
            CarId = rent.CarId;
        }
    }
}

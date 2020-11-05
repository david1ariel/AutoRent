using System;
using System.Collections.Generic;
using System.Text;

namespace BeardMan
{
    public class CarModel
    {
        public string CarId { get; set; }
        public int? Km { get; set; }
        public int? CarTypeId { get; set; }
        public bool? IsFixed { get; set; }
        public bool? IsAvailable { get; set; }
        public int? BranchId { get; set; }

        public CarModel(Car car)
        {
            CarId = car.CarId;
            Km = car.Km;
            CarTypeId = car.CarTypeId;
            if(car.IsFixed == 1)
                IsFixed = true;
            if (car.IsFixed == 0)
                IsFixed = false;
            if (car.IsAvailable == 1)
                IsAvailable = true;
            if (car.IsAvailable == 0)
                IsAvailable = false;
        }

        
    }
}

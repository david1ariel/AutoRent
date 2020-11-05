using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeardMan
{
    public class CarsLogic: BaseLogic
    {
        public CarsLogic(AutoRentContext db) : base(db) { }

    public List<CarModel> GetAllCars()
    {
        return DB.Cars.Select(p => new CarModel(p)).ToList();
    }
}
}

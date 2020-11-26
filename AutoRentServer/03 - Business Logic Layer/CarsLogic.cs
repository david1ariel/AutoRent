using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeardMan
{
    public class CarsLogic : BaseLogic
    {
        public CarsLogic(AutoRentContext db) : base(db) { }

        public AvailableCarModel ConstructAvaialbleCarModel(CarModel carModel)
        {
            CarTypeModel carTypeModel = new CarTypeModel(DB.CarTypes.SingleOrDefault(p => p.CarTypeId == carModel.CarTypeId));
            return new AvailableCarModel
            {
                CarId = carModel.CarId ,
                Manufacturer = carTypeModel.Manufacturer,
                Model = carTypeModel.Model,
                PricePerDay = carTypeModel.PricePerDay,
                PricePerDayLate = carTypeModel.PricePerDayLate,
                Year = carTypeModel.Year,
                Gear = carTypeModel.Gear,
                ImageFileName = carTypeModel.ImageFileName,
                Km = carModel.Km,
                CarTypeId = carModel.CarTypeId,
                IsFixed = carModel.IsFixed,
                IsAvailable = carModel.IsAvailable,
                BranchId = carModel.BranchId,
            };
        }

        public List<AvailableCarModel> GetAllAvailableCars()
        {
            return DB.Cars.Select(p => ConstructAvaialbleCarModel(new CarModel(p))).ToList();
        }

        public List<CarModel> GetAllCars()
        {
            return DB.Cars.Select(p => new CarModel(p)).ToList();
        }
    }
}

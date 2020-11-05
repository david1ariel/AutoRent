using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BeardMan
{
    public class CarTypesLogic : BaseLogic
    {
        public CarTypesLogic(AutoRentContext db) : base(db) { }

        public List<CarTypeModel> GetAllCarTypes()
        {
            return DB.CarTypes.Select(p => new CarTypeModel(p)).ToList();
        }

        public CarTypeModel UpdateCarType(CarTypeModel carTypeModel)
        {
            if (carTypeModel.Image != null)
            {
                string extension = Path.GetExtension(carTypeModel.Image.FileName);

                carTypeModel.ImageFileName = Guid.NewGuid() + extension;

                using (FileStream fileStream = File.Create("Uploads/" + carTypeModel.ImageFileName))
                {
                    carTypeModel.Image.CopyTo(fileStream);
                }
                carTypeModel.Image = null;
            }

            CarType carType = DB.CarTypes.SingleOrDefault(p => p.CarTypeId == carTypeModel.CarTypeId);

            carType.Manufacturer = carTypeModel.Manufacturer;
            carType.Model = carTypeModel.Model;
            carType.PricePerDay = carTypeModel.PricePerDay;
            carType.PricePerDayLate = carTypeModel.PricePerDayLate;
            carType.Year = carTypeModel.Year;
            carType.Gear = carTypeModel.Gear;
            carType.ImageFileName = carTypeModel.ImageFileName;


            DB.SaveChanges();
            return new CarTypeModel(carType);
        }

        public List<CarTypeModel> UpdateManyCarTypes(List<CarTypeModel> carTypesToUpdate)
        {
            foreach (var item in carTypesToUpdate)
            {
                this.UpdateCarType(item);
            }

            List<CarTypeModel> carTypesToReturn = new List<CarTypeModel>();

            foreach (var item in carTypesToUpdate)
            {
                carTypesToReturn.Add(new CarTypeModel(DB.CarTypes.SingleOrDefault(p => p.CarTypeId == item.CarTypeId)));
            }
            return carTypesToReturn;
        }

        




    }
}


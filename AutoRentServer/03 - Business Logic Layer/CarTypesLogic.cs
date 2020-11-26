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
            carTypeModel.CarTypeId = carType.CarTypeId;
            return carTypeModel;
        }

        public List<CarTypeModel> UpdateManyCarTypes(List<CarTypeModel> carTypesToUpdate)
        {
            for (int i = 0; i < carTypesToUpdate.Count; i++)
            {
                carTypesToUpdate[i] = this.UpdateCarType(carTypesToUpdate[i]);
            }

            return carTypesToUpdate;
        }

        




    }
}


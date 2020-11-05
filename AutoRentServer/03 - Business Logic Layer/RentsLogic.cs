using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeardMan
{
    public class RentsLogic : BaseLogic
    {
        public RentsLogic(AutoRentContext db) : base(db) { }

        public List<RentModel> GetAllRents()
        {
            return DB.Rents.Select(p => new RentModel(p)).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeardMan
{
    public class BranchesLogic: BaseLogic
    {
        public BranchesLogic(AutoRentContext db):base(db) { }

        public List<BranchModel> GetAllBranches()
        {
            return DB.Branches.Select(p => new BranchModel(p)).ToList();
        } 
    }
}

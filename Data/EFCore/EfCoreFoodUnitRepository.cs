using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NudelnDudeln.Data.EFCore
{
    public class EfCoreFoodUnitRepository : EFCoreRepository<FoodUnit, AppDbContext>
    {
        public EfCoreFoodUnitRepository(AppDbContext context) : base(context)
        {

        }
    }
}

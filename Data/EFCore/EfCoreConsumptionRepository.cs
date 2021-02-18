using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NudelnDudeln.Data.EFCore
{
    public class EfCoreConsumptionRepository : EFCoreRepository<Consumption, AppDbContext>
    {
        public EfCoreConsumptionRepository(AppDbContext context) : base(context)
        {

        }
    }
}

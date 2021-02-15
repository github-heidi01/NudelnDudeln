using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NudelnDudeln.Data.EFCore
{
    public class EfCoreCurrencyUnitRepository : EFCoreRepository<CurrencyUnit, AppDbContext>
    {
        public EfCoreCurrencyUnitRepository(AppDbContext context) : base(context)
        {

        }
    }
}

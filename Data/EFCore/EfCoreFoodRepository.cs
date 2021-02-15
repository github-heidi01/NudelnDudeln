using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NudelnDudeln.Data.EFCore
{
    public class EfCoreFoodRepository : EFCoreRepository<Food, AppDbContext>
    {
        public EfCoreFoodRepository(AppDbContext context) : base(context)
        {

        }
    }
}

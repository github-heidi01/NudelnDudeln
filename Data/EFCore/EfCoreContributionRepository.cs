using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NudelnDudeln.Data.EFCore
{
    public class EfCoreContributionRepository : EFCoreRepository<Contribution, AppDbContext>
    {
        public EfCoreContributionRepository(AppDbContext context) : base(context)
        {

        }
    }
}

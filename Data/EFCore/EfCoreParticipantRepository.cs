using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NudelnDudeln.Data.EFCore
{
    public class EfCoreParticipantRepository : EFCoreRepository<Participant, AppDbContext>
    {
        public EfCoreParticipantRepository(AppDbContext context) : base(context)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NudelnDudeln.Models
{
    public class Contribution
    {
        public int Id { get; set; }
        public Participant Contributor { get; set; }
        public decimal Amount { get; set; }
        public CurrencyUnit Currency { get; set; }
        public DateTime ContributedOn { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NudelnDudeln.Models
{
    public class Consumption
    {
        public int Id { get; set; }
        public Food FoodItem { get; set; }
        [RegularExpression(@"[0-9]{1,4}[,|.]{0, 1}[0-9]{0,2}")]
        public Decimal Amount { get; set; }
        public FoodUnit Unit { get; set; }
        public Participant Consumer { get; set; }
        public DateTime ConsumedOn { get; set; }

    }
}

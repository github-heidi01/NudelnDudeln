using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NudelnDudeln.Data
{
    public class Food
    {
        public int Id { get; set; }
        [StringLength(200, MinimumLength = 3)]
        public string FoodItem { get; set; }
    }
}

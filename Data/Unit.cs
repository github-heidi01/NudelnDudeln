using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NudelnDudeln.Data
{
    public class Unit
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 1)]
        public string UnitName { get; set; }
    }
}

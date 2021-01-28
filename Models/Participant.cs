using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NudelnDudeln.Models
{
    public class Participant
    {
        public int Id { get; set; }
        [StringLength(200, MinimumLength = 3)]
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}

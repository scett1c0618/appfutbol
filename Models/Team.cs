using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace appfutbol.Models
{
    public class Team
    {
        public int TeamId { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Assignment> Assignments { get; set; }
    }
}
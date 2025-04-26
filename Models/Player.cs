using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace appfutbol.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(15, 50)]
        public int Age { get; set; }

        [Required]
        public string Position { get; set; }

        public ICollection<Assignment> Assignments { get; set; }
    }
}
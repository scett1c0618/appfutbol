using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using appfutbol.Models;

namespace appfutbol.Models
{
    public class Assignment
    {
        public int AssignmentId { get; set; }

        public int PlayerId { get; set; }
        public int TeamId { get; set; }

        public Player Player { get; set; }
        public Team Team { get; set; }
    }
}
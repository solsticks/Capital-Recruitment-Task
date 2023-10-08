using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capital_placement_task.Models
{
    public class Profile
    {
        public string? Id { get; set; }
        public Education? Education { get; set; }

        [Required]
        public WorkExperience? Experience { get; set; }
        public string? Resume { get; set; }
        public Questions? AddAQuestion { get; set; }
    }
}

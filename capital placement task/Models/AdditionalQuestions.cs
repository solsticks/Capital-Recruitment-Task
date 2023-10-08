using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capital_placement_task.Models
{
    public class AdditionalQuestions
    {
        [MaxLength(499) ]
        public string? AboutMe { get; set; }
        public DateOnly GraduationYear { get; set; }
        public Questions? Question { get; set; }
    }
}

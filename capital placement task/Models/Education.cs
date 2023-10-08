using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace capital_placement_task.Models
{
    public class Education
    {
        public string? School { get; set; }
        public string? Degree { get; set; }
        public string? CourseName { get; set; }
        public string? LocationOfStudy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capital_placement_task.Models
{
    public class AdditionalInformation
    {
        public string? Id { get; set; }
        public string? ProgramType { get; set; }
        public DateTime ProgramStart { get; set; }
        public DateTime ApplicationOpen { get; set;}
        public DateTime ApplicationClose { get; set; }
        public string? Duration { get; set; }
        public string? ProgramLocation { get; set; }
        public string? MinQualification { get; set; }
        public string? MaxNumberOfApplication { get; set; }
    }
}

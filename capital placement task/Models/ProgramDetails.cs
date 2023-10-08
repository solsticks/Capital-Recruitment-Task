using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capital_placement_task.Models
{
    public class ProgramDetails
    {
        public string? Id { get; set; }
        public string? ProgramTitle { get; set; }
        public string? ProgramDescription { get; set;}
        public List<String>? KeySkills { get; set; }
        public string? ProgramBenefits { get; set; }
        public string? ApplicationCriteria { get; set; }
        public AdditionalInformation? AdditionalInfo { get; set; }
    }
}

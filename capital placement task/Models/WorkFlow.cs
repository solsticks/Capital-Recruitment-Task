using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace capital_placement_task.Models
{
    public class WorkFlow
    {
        public string? Id { get; set; }
        public List<string>? Stages { get; set; } 
        public string? StageName { get; set; }
        public Video? VideoInterview { get; set; }
    }    

    public class Video
    {
        public string? VideoQuestion { get; set; }
        public string? AdditionalInfo { get; set; }
        public string? MaxDuration { get; set; }
        public string? DeadlineForSubmition { get; set; }
    }
   
}

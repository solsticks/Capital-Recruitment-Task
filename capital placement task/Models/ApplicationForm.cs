using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capital_placement_task.Models
{
    public class ApplicationForm
    {
        public string? Id { get; set; }
        public string? UploadCoverImage { get; set; }
        public PersonalInformation? PersonalInfo { get; set; }
        public Profile? Profiles { get; set; }
        public AdditionalQuestions? AdditionalQuestions { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace capital_placement_task.Models
{
    public class PersonalInformation
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Nationality { get; set; }
        public string? CurrentAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public Questions? AddAQuestion { get; set; }       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capital_placement_task.Models
{
    public class Questions
    {
        public Type? Type { get; set; }
        public string? Question { get; set; }
    }

    public enum Type
    {
        Paragraph,
        ShortAnswer,
        YesOrNo,
        DropDown,
        MultipleChoice,
        Date,
        Number,
        FileUpload,
        VideoQuestion            
    }
}

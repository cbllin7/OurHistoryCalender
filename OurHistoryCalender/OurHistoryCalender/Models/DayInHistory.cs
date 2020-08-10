using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurHistoryCalender.Models
{
    public class DayInHistory
    {
        public DateTime DateInHistory { get; set; }
        public string DayInHistoryTitle { get; set; }
        public string BriefDescription { get; set; }
        public string DayInHistoryImage { get; set; }
        public string Source { get; set; }
    }
}

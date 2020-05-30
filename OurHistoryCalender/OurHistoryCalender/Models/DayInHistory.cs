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
        public string BriefDescription { get; set; }
        public string Image { get; set; }
        public string Source { get; set; }
    }
}

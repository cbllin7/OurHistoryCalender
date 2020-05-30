using OurHistoryCalender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamForms.Controls;

namespace OurHistoryCalender.Services
{
    public interface ICalenderEventService
    {
        void EventAdd(DayInHistory dayInHistory);
        IEnumerable<SpecialDate> getDaysInHistory();
        void RemoveEvent();
    }
}

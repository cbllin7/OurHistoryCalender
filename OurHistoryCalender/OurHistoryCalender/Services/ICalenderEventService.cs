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
        IEnumerable<DayInHistory> getDaysInHistory();
        ICollection<SpecialDate> getSpecialDays();
        void RemoveEvent();
        void Save(IEnumerable<DayInHistory> dayInHistories);
    }
}

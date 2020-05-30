using Newtonsoft.Json;
using OurHistoryCalender.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamForms.Controls;

namespace OurHistoryCalender.Services
{
    public class CalenderEventService : ICalenderEventService
    {
        public void EventAdd(DayInHistory dayInHistory)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SpecialDate> getDaysInHistory()
        {
            IList<SpecialDate> specialDates = new List<SpecialDate>();
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("CalenderEvents.json");

            using (var reader = new System.IO.StreamReader(stream))
            {

                var json = reader.ReadToEnd();
                var data = JsonConvert.DeserializeObject<IEnumerable<DayInHistory>>(json);
                foreach (DayInHistory dayInHistory in data)
                {
                    SpecialDate specialDate = new SpecialDate(dayInHistory.DateInHistory);
                    specialDate.BackgroundImage.File = dayInHistory.Image;
                }
            }
            return specialDates;
        }

        public void RemoveEvent()
        {
            throw new NotImplementedException();
        }
    }
}

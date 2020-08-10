using Newtonsoft.Json;
using OurHistoryCalender.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using XamForms.Controls;

namespace OurHistoryCalender.Services
{
    public class CalenderEventService : ICalenderEventService
    {
        public IEnumerable<DayInHistory> getDaysInHistory()
        {
            IEnumerable<DayInHistory> daysInHistory;
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("OurHistoryCalender.CalenderEvents.json");

            using (var reader = new System.IO.StreamReader(stream))
            {

                var json = reader.ReadToEnd();
                daysInHistory = JsonConvert.DeserializeObject<IEnumerable<DayInHistory>>(json);
            }
        
            return daysInHistory;
        
        }

        public ICollection<SpecialDate> getSpecialDays()
        {
            IList<SpecialDate> specialDates = new List<SpecialDate>();
            var daysInHistory = getDaysInHistory();
                foreach (DayInHistory dayInHistory in daysInHistory)
                {
                    SpecialDate specialDate = new SpecialDate(dayInHistory.DateInHistory);
                    specialDates.Add(specialDate);
                }
            return specialDates;
        }

        public void EventAdd(DayInHistory dayInHistory)
        {
            throw new NotImplementedException();
        }

        public void RemoveEvent()
        {
            throw new NotImplementedException();
        }

        public void Save(IEnumerable<DayInHistory> dayInHistories)
        {
            var jsonfile = "CalenderEvents.json";
            try
            {
                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(dayInHistories,
                                       Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(jsonfile, newJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Add Error : " + ex.Message.ToString());
            }
        }
    }
}

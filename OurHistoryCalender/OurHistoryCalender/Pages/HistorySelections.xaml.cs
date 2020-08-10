using OurHistoryCalender.Models;
using OurHistoryCalender.Notifications;
using OurHistoryCalender.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OurHistoryCalender.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistorySelections : ContentPage
    {
        private ICalenderEventService _calenderEventService;
        private IEnumerable<DayInHistory> _dayInHistory;
        
        public HistorySelections()
        {
            InitializeComponent();
            _calenderEventService = new CalenderEventService();
            listView.ItemsSource = (IEnumerable)GetTaskListAsync();
        }

        private async Task OnItemClickAsync(DayInHistory dayInHistory)
        {
            await Navigation.PushModalAsync(new AboutDateInHistory(dayInHistory));
        }

        private async Task<IEnumerable<DayInHistory>> GetTaskListAsync()
        {
            _dayInHistory = _calenderEventService.getDaysInHistory();
            return await Task.FromResult(_dayInHistory);
        }
    }
}
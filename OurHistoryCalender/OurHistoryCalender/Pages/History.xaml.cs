using OurHistoryCalender.Models;
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
    public partial class History : ContentPage
    {

        private ICalenderEventService _calenderEventService;
        private IEnumerable<DayInHistory> _dayInHistory;

        public History()
        {
            InitializeComponent();
            _calenderEventService = new CalenderEventService();
            listView.ItemsSource = _calenderEventService.getDaysInHistory();
        }

        private async Task OnItemClickAsync(DayInHistory dayInHistory)
        {
            await Navigation.PushAsync(new AboutDateInHistory(dayInHistory));
        }

        public async Task OnCreateClickAsync(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddSpecialDay());
        }

        private async Task<IEnumerable<DayInHistory>> GetTaskListAsync()
        {
            _dayInHistory = _calenderEventService.getDaysInHistory();
            return await Task.FromResult(_dayInHistory);
        }
    }
}
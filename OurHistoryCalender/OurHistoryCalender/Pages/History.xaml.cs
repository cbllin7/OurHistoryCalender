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
            Image image = new Image
            {
                Source = "Images.plus.png"
            };
        }

        void OnItemClickAsync(object sender, ItemTappedEventArgs e)
        {
            var myListView = (ListView)sender;
            var selectedDayInHistory = (DayInHistory)myListView.SelectedItem;
            Navigation.PushModalAsync(new AboutDateInHistory(selectedDayInHistory));
        }

        void OnCreateClickAsync(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddSpecialDay());
        }
    }
}
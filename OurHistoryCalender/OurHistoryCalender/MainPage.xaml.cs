using OurHistoryCalender.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamForms.Controls;

namespace OurHistoryCalender
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Calendar calendar = new Calendar();
        ICalenderEventService _calenderEventService = new CalenderEventService();
        public MainPage()
        {
            InitializeComponent();
            getEvents(); 
        }

        async private void Calendar_DateClicked(object sender, DateTimeEventArgs e)
        {
            var dateSelected = e.DateTime.ToString("MM/dd/yyyy");
            await DisplayAlert("Alert", dateSelected, "Ok");
        }

        public void getEvents()
        {
            calendar.SpecialDates = _calenderEventService.getSpecialDays();
        }
    }
}

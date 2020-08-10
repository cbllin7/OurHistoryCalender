using OurHistoryCalender.Notifications;
using OurHistoryCalender.Services;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using XamForms.Controls;

namespace OurHistoryCalender
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private Calendar calendar = new Calendar();
        private ICalenderEventService _calenderEventService = new CalenderEventService();
        private INotificationManager notificationManager;
        int notificationNumber = 0;
        public MainPage()
        {
            InitializeComponent();
            getEvents();
            notificationManager = DependencyService.Get<INotificationManager>();
            notificationManager.NotificationReceived += (sender, eventArgs) =>
            {
                var evtData = (NotificationEventArgs)eventArgs;
                ShowNotification(evtData.Title, evtData.Message);
            };
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
        void OnScheduleClick(object sender, EventArgs e)
        {
            notificationNumber++;
            string title = $"Local Notification #{notificationNumber}";
            string message = $"You have now received {notificationNumber} notifications!";
            notificationManager.ScheduleNotification(title, message);
        }

        void ShowNotification(string title, string message)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var msg = new Label()
                {
                    Text = $"Notification Received:\nTitle: {title}\nMessage: {message}"
                };
                stackLayout.Children.Add(msg);
            });
        }
    }
}

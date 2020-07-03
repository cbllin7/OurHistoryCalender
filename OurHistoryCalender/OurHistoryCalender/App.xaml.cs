using OurHistoryCalender.Notifications;
using Xamarin.Forms;

namespace OurHistoryCalender
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // use the dependency service to get a platform-specific implementation and initialize it
            DependencyService.Get<INotificationManager>().Initialize();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

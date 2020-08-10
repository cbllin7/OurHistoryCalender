using OurHistoryCalender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OurHistoryCalender.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutDateInHistory : ContentPage
    {
        private readonly DayInHistory _dayInHistory;
        public AboutDateInHistory(DayInHistory dayInHistory)
        {
            _dayInHistory = dayInHistory;
            InitializeComponent();
        }

        public string GetHistory()
        {
            return _dayInHistory.BriefDescription;
        }
    }
}
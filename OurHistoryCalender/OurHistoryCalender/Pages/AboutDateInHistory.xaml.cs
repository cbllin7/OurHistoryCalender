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
        public AboutDateInHistory()
        {
            InitializeComponent();
        }

        public string GetHistory(DayInHistory selectedDayInHistory)
        {
            return selectedDayInHistory.BriefDescription;
        }
    }
}
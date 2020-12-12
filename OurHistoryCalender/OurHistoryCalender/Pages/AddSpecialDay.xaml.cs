using OurHistoryCalender.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OurHistoryCalender.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddSpecialDay : ContentPage
    {
        public DayInHistory newDayInHistory;
        public AddSpecialDay()
        {
            InitializeComponent();
            newDayInHistory = new DayInHistory();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine(newDayInHistory);
        }
    }
}
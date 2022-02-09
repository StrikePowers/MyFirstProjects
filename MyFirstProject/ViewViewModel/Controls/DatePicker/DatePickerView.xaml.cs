using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Controls.DatePicker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerView : ContentPage
    {
        public DatePickerView()
        {
            InitializeComponent();
            BindingContext = new DatePickerViewModel();
        }

        private void StartDatePicker _DateSelected(object sender, DateChangedEventArgs e)
        {
            _startDateSelected = e.NewDate;
            _oStartDateSelected = e.OldDate;
        }

        private void EndDatePicker _DateSelected(object sender, DateChangedEventArgs e)
        {
            _endDateSelected = e.NewDate;
            _oEndDateSelected = e.OldDate;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        { 
            string msg = "The start date selected is: " + _startDateSelected.ToShortDateString(); + ", " +
                         "The end date selected is: " + _endDateSelected.ToShortDateString();

            await Application.Current.MainPage.DisplayAlert(Titles.DatePickerXamlTitle, msg, "ok");
        }

    }
}

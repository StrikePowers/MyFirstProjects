using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.Controls.DatePicker;
using MyFirstProject.ViewViewModel.Controls.Entry;
using MyFirstProject.ViewViewModel.Controls.Picker;
using MyFirstProject.ViewViewModel.Controls.Slider;
using MyFirstProject.ViewViewModel.Controls.Stepper;
using MyFirstProject.ViewViewModel.Controls.Switch;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls
{
    public class ControlsMenuViewModel : BaseViewModel
    {
        public ICommand OnSliderClicked { get; set; }
        public ICommand OnStepperClicked { get; set; }
        public ICommand OnSwitchClicked { get; set; }
        public ICommand OnEntryClicked { get; set; }
        public ICommand OnPickerClicked { get; set; }
        public ICommand OnDatePickClicked { get; set; }
        public ControlsMenuViewModel()
        {
            Title = Titles.ControlsTitle;
            OnSliderClicked = new Command(OnSliderClickedAsync);
            OnStepperClicked = new Command(OnStepperClickedAsync);
            OnSwitchClicked = new Command(OnSwitchClickedAsync);
            OnEntryClicked = new Command(OnEntryClickedAsync);
            OnPickerClicked = new Command(OnPickerClickedAsync);
            OnDatePickClicked = new Command(OnDatePickClickedAsync);
        }

        private async void OnPickerClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerMenuView());
        }
        private async void OnSliderClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SliderView());
        }

        private async void OnStepperClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new StepperView());
        }

        private async void OnSwitchClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SwitchView());
        }

        private async void OnEntryClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EntryFormView());
        }

        private async void OnDatePickClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerView());
        }
    }
}

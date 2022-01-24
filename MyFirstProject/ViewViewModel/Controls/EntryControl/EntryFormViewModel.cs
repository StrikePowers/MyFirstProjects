using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.EntryControl
{
    public class EntryFormViewModel : BaseViewModel
    {
        public ICommand OnEntryClicked { get; }
        private string _entryText = string.Empty;

        public EntryFormViewModel()
        {
            Title = Titles.EntryFormTitle;
            OnEntryClicked = new Command(OnEntryClickedAsync);
        }

        public string EntryText
        {
            get { return _entryText; }

            set
            {
                if (_entryText != value)
                    SetProperty(ref _entryText, value);
            }
        }

        private async void OnEntryClickedAsync(object obj)
        {
            if (string.IsNullOrEmpty(_entryText.Trim()))
            {
                await Application.Current.MainPage.DisplayAlert(Titles.EntryFormTitle, "Entry can't be empty!", "Ok");

                return;
            }

            else
            {
                await Application.Current.MainPage.Navigation.PushAsync(new EntryResultView(_entryText));
            }
        }
    }
}
using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.Entry
{
    public class EntryMenuViewModel : BaseViewModel
    {
        public ICommand OnEntryLinkClicked { get; set; }
        public EntryMenuViewModel()
        {
            Title = Titles.EntryMenuTitle;
            OnEntryLinkClicked = new Command(OnEntryLinkClickedAsync);
        }

        private async void OnEntryLinkClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EntryFormView());
        }
    }
}
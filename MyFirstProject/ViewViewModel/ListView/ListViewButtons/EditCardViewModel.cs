using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.ListView.ListViewButtons
{
    public class EditCardViewModel : BaseViewModel
    {
        public ICommand UpdateButtonClicked { get; set; }
        private string _cardText = string.Empty;

        public EditCardViewModel()
        {
            Title = Titles.ListViewEditTitle;
            UpdateButtonClicked = new Command(PerformSave);
        }

        public string CardText
        {
            get { return _cardText; }

            set
            {
                if (_cardText != value)
                {
                    SetProperty(ref _cardText, value);
                }
            }
        }

        public void PerformSave()
        {
            if (string.IsNullOrEmpty(_cardText.Trim()))
            {
                Application.Current.MainPage.DisplayAlert(Titles.AddTitle, Msgs.NotEmpty, "Ok");
                return;
            }

            PlayingCard cards = new PlayingCard(_cardText);

            MessagingCenter.Send<PlayingCard>(cards, "UpdatedCards");
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
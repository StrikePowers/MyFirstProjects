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
    public class AddCardViewModel : BaseViewModel
    {
        public ICommand SaveButtonClicked { get; set; }
        private string _cardText = string.Empty;
        public AddCardViewModel()
        {
            Title = Titles.ListViewAddTitle;

            SaveButtonClicked = new Command(PreformSave);
        }
        public void PreformSave()
        {
            if (string.IsNullOrEmpty(_cardText.Trim()))
            {
                Application.Current.MainPage.DisplayAlert(Titles.AddTitle, Msgs.NotEmpty, "Ok");
                return;
            }

            PlayingCard cards = new PlayingCard();
            cards.Name = _cardText;

            MessagingCenter.Send<PlayingCard>(cards, "AddCards");
            Application.Current.MainPage.Navigation.PopAsync();
        }

    public string CardText
        {
            get { return _cardText; }

            set
            {
                if (_cardText != value)
                    SetProperty(ref _cardText, value);
            }
        }
    }
}
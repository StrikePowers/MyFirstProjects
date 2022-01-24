using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.ListView.ListViewButtons
{
    public class ListViewButtonsViewModel : ContentPage
    {
        private List<PlayingCard> _card;
        private ObservableCollection<PlayingCard> _cards;

        public ListViewButtonsViewModel()
        {
            Title = Titles.ListViewButtonsTitle;

            _cards = new ObservableCollection<PlayingCard>();
            _card = PlayingCard.GetCardButton();
            this.LoadCards();
        }

        private void LoadCards()
        {
            try
            {
                _cards.Clear();
                foreach (var c in _card)
                {
                    Cards.Add(c);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public ObservableCollection<PlayingCard> Cards
        {
            get
            {
                return _cards;
            }
            set
            {
                _cards = value;
                OnPropertyChanged();
            }
        }

        public Command<PlayingCard> DeleteCommand
        {
            get
            {
                return new Command<PlayingCard>((PlayingCard card) =>
                {
                    Cards.Remove(card);
                });
            }
        }

        public Command<PlayingCard> UpdateCommand
        {
            get
            {
                return new Command<PlayingCard>((PlayingCard card) =>
                {
                    Application.Current.MainPage.Navigation.PushAsync(new EditCardView(card));

                    MessagingCenter.Subscribe<PlayingCard>(this, "UpdatedCards", async (data) =>
                    {
                        var index = Cards.IndexOf(card);

                        Cards.RemoveAt(index);
                        Cards.Insert(index, data);

                        MessagingCenter.Unsubscribe<PlayingCard>(this, "UpdatedCards");
                    });
                });
            }
        }

        public Command AddCommand
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage.Navigation.PushAsync(new AddCardView());
                    MessagingCenter.Subscribe<PlayingCard>(this, "AddCards", async (data) =>
                    {
                        Cards.Add(data);

                        MessagingCenter.Unsubscribe<PlayingCard>(this, "AddCards");
                    });
                });
            }
        }
    }
}
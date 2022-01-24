using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.ListView.ListViewButtons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.ListView.ListViewIcons
{
    public class ListViewIconsViewModel : ContentPage
    {
        public ImageSource EmbeddedImageSrc { get; set; }
        private List<PlayingCard> _card;
        private ObservableCollection<PlayingCard> _cards;

        public ListViewIconsViewModel()
        {
            Title = Titles.ListViewIconsTitle;

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

        private void GetImageSource()
        {
            EmbeddedImageSrc = ImageSource.FromResource("MyFirstProject.Images.edit.png");
        }
    }
}
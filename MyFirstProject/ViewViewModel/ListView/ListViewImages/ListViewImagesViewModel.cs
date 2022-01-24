using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.ListView.ListViewImages
{
   public class ListViewImagesViewModel : BaseViewModel
    {
        public ObservableCollection<PlayingCard> Cards { get; set; }
        private List<PlayingCard> _card;

        public ListViewImagesViewModel()
        {
            Title = Titles.ListViewImagesTitle;

            Cards = new ObservableCollection<PlayingCard>();
            _card = PlayingCard.GetCard();
            this.LoadCards();
        }

        private void LoadCards()
        {
            try
            {
                Cards.Clear();
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
    }
}
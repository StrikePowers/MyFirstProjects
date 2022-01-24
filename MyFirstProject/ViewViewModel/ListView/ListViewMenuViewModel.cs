using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.ListView.ListViewButtons;
using MyFirstProject.ViewViewModel.ListView.ListViewIcons;
using MyFirstProject.ViewViewModel.ListView.ListViewImages;
using MyFirstProject.ViewViewModel.ListView.ListViewNames;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.ListView
{
    class ListViewMenuViewModel : BaseViewModel
    {
        public ICommand OnListViewNamesClicked { get; set; }
        public ICommand OnListViewImagesClicked { get; set; }
        public ICommand OnListViewButtonsClicked { get; set; }
        public ICommand OnListViewIconsClicked { get; set; }

        public ListViewMenuViewModel()
        {
            Title = Titles.ListViewTitle;
            OnListViewNamesClicked = new Command(OnListViewNamesClickedAsync);
            OnListViewImagesClicked = new Command(OnListViewImagesClickedAsync);
            OnListViewButtonsClicked = new Command(OnListViewButtonsClickedAsync);
            OnListViewIconsClicked = new Command(OnListViewIconsClickedAsync);
        }
        private async void OnListViewNamesClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListViewNamesView());
        }
        private async void OnListViewImagesClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListViewImagesView());
        }
        private async void OnListViewButtonsClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListViewButtonsView());
        }
        private async void OnListViewIconsClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListViewIconsView());
        }
    }
}

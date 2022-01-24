using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.Controls;
using MyFirstProject.ViewViewModel.Image;
using MyFirstProject.ViewViewModel.Layouts;
using MyFirstProject.ViewViewModel.ListView;
using MyFirstProject.ViewViewModels;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Main
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand OnLayoutsMenuClicked { get; set; }
        public ICommand OnControlsMenuClicked { get; set; }
        public ICommand OnListMenuClicked { get; set; }
        public ICommand OnImageMenuClicked { get; set; }
        public MainPageViewModel()
        {
            Title = Titles.MainPageTitle;
            Subtitle = Titles.MainPageSubtitle;

            OnLayoutsMenuClicked = new Command(OnLayoutsMenuClickedAsync);
            OnControlsMenuClicked = new Command(OnControlsMenuClickedAsync);
            OnListMenuClicked = new Command(OnListMenuClickedAsync);
            OnImageMenuClicked = new Command(OnImageMenuClickedAsync);
        }

        private async void OnLayoutsMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutsMenuView());
        }

        private async void OnControlsMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ControlsMenuView());
        }

        private async void OnListMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListViewMenuView());
        }

        private async void OnImageMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ImageMenuView());
        }
    }
}

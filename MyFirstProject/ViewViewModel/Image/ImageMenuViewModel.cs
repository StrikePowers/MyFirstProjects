using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.Image.ActivityIndicator;
using MyFirstProject.ViewViewModel.Image.CacheImage;
using MyFirstProject.ViewViewModel.Image.EmbeddedImageProject;
using MyFirstProject.ViewViewModel.Image.EmbeddedImages;
using MyFirstProject.ViewViewModel.Image.URLImage;
using MyFirstProject.ViewViewModel.Image.URLImageProject;
using MyFirstProject.ViewViewModels;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Image
{
    class ImageMenuViewModel : BaseViewModel
    {
        public ICommand OnEmbeddedImagesClicked  { get; set; }
        public ICommand OnEmbeddedImageProjectClicked { get; set; }
        public ICommand OnURLImageClicked { get; set; }
        public ICommand OnURLImageProjectClicked { get; set; }
        public ICommand OnCacheImageClicked { get; set; }
        public ICommand OnActivityIndicatorClicked { get; set; }
        public ImageMenuViewModel()
        {
            Title = Titles.ImageTitle;
            OnEmbeddedImagesClicked = new Command(OnEmbeddedImagesClickedAsync);
            OnEmbeddedImageProjectClicked = new Command(OnEmbeddedImageProjectClickedAsync);
            OnURLImageClicked = new Command(OnURLImageClickedAsync);
            OnURLImageProjectClicked = new Command(OnURLImageProjectClickedAsync);
            OnCacheImageClicked = new Command(OnCacheImageClickedAsync);
            OnActivityIndicatorClicked = new Command(OnActivityIndicatorClickedAsync);
        }

        private async void OnEmbeddedImagesClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EmbeddedImagesView());
        }
        private async void OnEmbeddedImageProjectClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EmbeddedImageProjectView());
        }
        private async void OnURLImageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new URLImageView());
        }
        private async void OnURLImageProjectClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new URLImageProjectView());
        }
        private async void OnCacheImageClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CacheImageView());
        }

        private async void OnActivityIndicatorClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ActivityIndicatorView());
        }
    }
}

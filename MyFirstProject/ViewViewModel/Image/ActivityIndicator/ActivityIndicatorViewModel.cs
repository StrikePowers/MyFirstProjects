using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Image.ActivityIndicator
{
    class ActivityIndicatorViewModel : BaseViewModel
    {
        public ImageSource ActivityIndicatorImageSrc { get; set; }
        public ActivityIndicatorViewModel()
        {
            Title = Titles.ActivityIndicatorTitle;
            this.GetImageSource();
        }

        private void GetImageSource()
        {
            ActivityIndicatorImageSrc = ImageSource.FromResource("MyFirstProject.Images.SkyImage.jpg");
        }
    }
}
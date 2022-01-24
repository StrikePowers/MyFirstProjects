using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Image.EmbeddedImages
{
    class EmbeddedImagesViewModel : BaseViewModel
    {
        public ImageSource EmbeddedImageSrc { get; set; }
        public EmbeddedImagesViewModel()
        {
            Title = Titles.EmbeddedImagesTitle;
            this.GetImageSource();
        }

        private void GetImageSource()
        {
            EmbeddedImageSrc = ImageSource.FromResource("MyFirstProject.Images.SkyImage.jpg");
        }
    }
}
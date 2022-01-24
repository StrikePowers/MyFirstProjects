using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.Models
{
    public static class Images
    {
        //Embedded Image Project
        public static ImageSource EmbeddedImageProjectImageSrc = ImageSource.FromResource("MyFirstProject.Images.Hawk.jpg");

        //Icons Project
        public static ImageSource EditButton = ImageSource.FromResource("MyFirstProject.Images.edit.png");
        public static ImageSource DeleteButton = ImageSource.FromResource("MyFirstProject.Images.delete.png");

        //URL Image Project
        public static ImageSource GetImage()
        {
            var imgsrc = new UriImageSource { Uri = new Uri("https://placeimg.com/640/480/arch") };
            imgsrc.CachingEnabled = false;
            imgsrc.CacheValidity = TimeSpan.FromHours(1);

            return imgsrc;
        }
    }
}

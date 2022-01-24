using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Image.URLImageProject
{
    public class URLImageProjectViewModel : BaseViewModel
    {
        public string Image { get; set; }
        public URLImageProjectViewModel()
        {
            Title = Titles.URLImageProjectTitle;
            this.GetImage();
        }
        private void GetImage()
        {
            Image = "https://placeimg.com/640/480/animals";
        }
    }
}
using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Image.CacheImage
{
    public class CacheImageViewModel : BaseViewModel
    {
        public ImageSource Image { get; set; }
        public CacheImageViewModel()
        {
            Title = Titles.CacheImageTitle;
            Image = Images.GetImage();
        }
    }
}
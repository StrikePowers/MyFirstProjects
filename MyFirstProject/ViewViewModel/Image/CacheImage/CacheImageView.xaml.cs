using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Image.CacheImage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CacheImageView : ContentPage
    {
        public CacheImageView()
        {
            InitializeComponent();
            BindingContext = new CacheImageViewModel();
        }
    }
}
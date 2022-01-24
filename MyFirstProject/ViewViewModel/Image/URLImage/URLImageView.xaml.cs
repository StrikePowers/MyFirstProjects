using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Image.URLImage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class URLImageView : ContentPage
    {
        public URLImageView()
        {
            InitializeComponent();
            BindingContext = new URLImageViewModel();
        }
    }
}
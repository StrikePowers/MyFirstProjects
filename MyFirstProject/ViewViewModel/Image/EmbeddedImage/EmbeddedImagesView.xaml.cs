using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Image.EmbeddedImages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmbeddedImagesView : ContentPage
    {
        public EmbeddedImagesView()
        {
            InitializeComponent();
            BindingContext = new EmbeddedImagesViewModel();
        }
    }
}
using MyFirstProject.ViewViewModel.Image.EmbeddedImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Image.EmbeddedImageProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmbeddedImageProjectView : ContentPage
    {
        public EmbeddedImageProjectView()
        {
            InitializeComponent();
            BindingContext = new EmbeddedImageProjectViewModel();
        }
    }
}
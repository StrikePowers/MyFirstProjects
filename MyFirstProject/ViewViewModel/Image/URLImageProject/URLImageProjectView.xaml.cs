using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Image.URLImageProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class URLImageProjectView : ContentPage
    {
        public URLImageProjectView()
        {
            InitializeComponent();
            BindingContext = new URLImageProjectViewModel();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Controls.Slider
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SliderView : ContentPage
    {
        public SliderView()
        {
            InitializeComponent();
            BindingContext = new SliderViewModel();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Layouts.AbsoluteLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsoluteLayoutView : ContentPage
    {
        public AbsoluteLayoutView()
        {
            InitializeComponent();
            BindingContext = new AbsoluteLayoutViewModel();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Layouts.RelativeLayoutProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativeLayoutProjectView : ContentPage
    {
        public RelativeLayoutProjectView()
        {
            InitializeComponent();
            BindingContext = new RelativeLayoutProjectViewModel();
        }
    }
}
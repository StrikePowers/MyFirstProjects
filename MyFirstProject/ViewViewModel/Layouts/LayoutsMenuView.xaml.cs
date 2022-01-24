using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Layouts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LayoutsMenuView : ContentPage
    {
        public LayoutsMenuView()
        {
            InitializeComponent();
            BindingContext = new LayoutsMenuViewModel();
        }
    }
}
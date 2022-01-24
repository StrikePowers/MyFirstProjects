using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.ListView.ListViewIcons
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewIconsView : ContentPage
    {
        public ListViewIconsView()
        {
            InitializeComponent();
            BindingContext = new ListViewIconsViewModel();
        }
    }
}
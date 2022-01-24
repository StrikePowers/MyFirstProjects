using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewMenuView : ContentPage
    {
        public ListViewMenuView()
        {
            InitializeComponent();
            BindingContext = new ListViewMenuViewModel();
        }
    }
}
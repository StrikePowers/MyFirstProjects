using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.ListView.ListViewNames
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewNamesView : ContentPage
    {
        public ListViewNamesView()
        {
            InitializeComponent();
            BindingContext = new ListViewNamesViewModel();
        }
    }
}
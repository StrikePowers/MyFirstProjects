using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Controls.Entry
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryMenuView : ContentPage
    {
        public EntryMenuView()
        {
            BindingContext = new EntryMenuViewModel();
            InitializeComponent();
        }
    }
}
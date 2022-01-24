using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Controls.EntryControl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryResultView : ContentPage
    {
        public EntryResultView(string textInput)
        {
            InitializeComponent();
            BindingContext = new EntryResultViewModel(textInput);
        }
    }
}
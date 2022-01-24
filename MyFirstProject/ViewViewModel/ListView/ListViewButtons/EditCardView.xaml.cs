using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.ListView.ListViewButtons
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditCardView : ContentPage
    {
        public EditCardView(PlayingCard card)
        {
            InitializeComponent();
            BindingContext = new EditCardViewModel();
            Title.Text = card.Name;
        }
    }
}
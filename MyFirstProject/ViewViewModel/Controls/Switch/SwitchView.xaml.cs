using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Controls.Switch
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwitchView : ContentPage
    {
        public SwitchView()
        {
            InitializeComponent();
            this.BindingContext = new SwitchViewModel(); 
        }
        private void SwitchToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value == false)
            {
                label.TextColor = Color.Red;
            }
            else
            {
                label.TextColor = Color.Blue;
            }


            }
    }
}
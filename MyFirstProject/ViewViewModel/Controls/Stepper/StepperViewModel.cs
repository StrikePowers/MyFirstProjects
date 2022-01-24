using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.Stepper
{
    public class StepperViewModel : BaseViewModel
    {
        public StepperViewModel()
        {
            Title = Titles.StepperTitle;
        }
    }
}
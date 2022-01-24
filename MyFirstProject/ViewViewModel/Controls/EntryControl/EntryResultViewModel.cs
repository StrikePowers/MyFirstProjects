using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.EntryControl
{
    public class EntryResultViewModel : BaseViewModel
    {
        public string resultsText;

        public EntryResultViewModel(string textInput)
        {
            Title = Titles.EntryResultTitle;
            resultsText = textInput;
        }

        public string ResultsText 
        {
            get { return resultsText; }

            set
            {
                if (resultsText != value)
                    SetProperty(ref resultsText, value);
            }
        }
    }
}
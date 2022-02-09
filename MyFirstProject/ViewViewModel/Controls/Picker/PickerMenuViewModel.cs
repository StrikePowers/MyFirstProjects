using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.Picker
{
    public class PickerMenuViewModel : BaseViewModel
    {
        public ImageSource ImgSrc { get; set; }
        private string _pickerSelection;
        public PickerMenuViewModel(string name, string image)
        {
            ImgSrc = this.SetImageSrc(image);
            _pickerSelection = name;
        }

        private ImageSource SetImageSrc(string img)
        {
            var imgsrc = new UriImageSource { Uri = new Uri(img) };
            imgsrc.CachingEnabled = false;

            return imgsrc;
        }

        public string PickerSelection
        {
            get { return _pickerSelection; }
        }
    }
}

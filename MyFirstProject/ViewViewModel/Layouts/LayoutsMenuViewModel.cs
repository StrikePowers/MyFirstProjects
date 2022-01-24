using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.Layouts.AbsoluteLayout;
using MyFirstProject.ViewViewModel.Layouts.AbsoluteLayoutProject;
using MyFirstProject.ViewViewModel.Layouts.RelativeLayout;
using MyFirstProject.ViewViewModel.Layouts.RelativeLayoutProject;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Layouts
{
    class LayoutsMenuViewModel : BaseViewModel
    {
        public ICommand OnAbsoluteLayoutClicked { get; set; }
        public ICommand OnRelativeLayoutClicked { get; set; }
        public ICommand OnAbsoluteLayoutProjectClicked { get; set; }
        public ICommand OnRelativeLayoutProjectClicked { get; set; }
        public LayoutsMenuViewModel()
        {
            Title = Titles.LayoutsTitle;
            OnAbsoluteLayoutClicked = new Command(OnAbsoluteLayoutClickedAsync);
            OnRelativeLayoutClicked = new Command(OnRelativeLayoutClickedAsync);
            OnAbsoluteLayoutProjectClicked = new Command(OnAbsoluteLayoutProjectClickedAsync);
            OnRelativeLayoutProjectClicked = new Command(OnRelativeLayoutProjectClickedAsync);
        }
        private async void OnAbsoluteLayoutClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteLayoutView());
        }

        private async void OnRelativeLayoutClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RelativeLayoutView());
        }
        private async void OnAbsoluteLayoutProjectClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteLayoutProjectView());
        }

        private async void OnRelativeLayoutProjectClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RelativeLayoutProjectView());
        }
    }
}

using System;
using System.Collections.Generic;
using LogicApp.ViewModels;
using Xamarin.Forms;
using LogicApp.Models;

namespace LogicApp.Views
{
    public partial class ExaminationsPage : ContentPage
    {
        public ExaminationsPage()
        {
            InitializeComponent();
            BindingContext = new ExaminationsViewModel();
        }

        async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ExaminationPage(((sender as StackLayout).BindingContext as Group).Id, "select"));
        }

        async void TapGestureRecognizer_Tapped_1(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ExaminationPage(((sender as StackLayout).BindingContext as Group).Id, "letter"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LogicApp.Views;
using LogicApp.ViewModels;
using Xamarin.Essentials;

namespace LogicApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WordPage : ContentPage
    {
        int _groupNumber, _currentImage, _subgroupNumber;
        DateTime _startTime;

        public WordPage(int groupNumber, int subgroupNumber, string subgroupName, int currentImage, bool isResume)
        {
            _groupNumber = groupNumber;
            _subgroupNumber = subgroupNumber;
            _currentImage = currentImage;

            // Initialize the ViewModel
            var vm = new WordPageViewModel();
            BindingContext = vm;
            vm.InitializeGroup(_groupNumber, _subgroupNumber, _currentImage);
            InitializeComponent();
            Title = LogicApp.Resources.AppResources.Group + " " + (_groupNumber + 1) + " - " + subgroupName;

            // If resume add the subgroups in between
            if (isResume)
            {
                //Navigation.InsertPageBefore(new SubgroupsPage(groupNumber), this);
            }

            // Fix for the bug of grid taking original image size for height.
            //automatedPlayImageButton.SizeChanged += (o, e) => { buttonsGrid.HeightRequest = previousButton.Height; }; // It does not always work...
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            // Start timer
            _startTime = DateTime.Now;

            if (Device.RuntimePlatform == Device.iOS)
            {
                // Save to preference to overcome the iOS problems...
                Preferences.Set("timerStartTime", _startTime);
                Preferences.Set("timerRunning", true);
                Preferences.Set("subGroupNumber", _groupNumber + "-" + _subgroupNumber);
            }
                
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            // Stop the sound
            ((WordPageViewModel)BindingContext).CancelSound();

            // Get elapsed time
            TimeSpan interval;
            if (Device.RuntimePlatform == Device.iOS)
            {
                // Take it from preferences to handle iOS way of doing
                interval = DateTime.Now - Preferences.Get("timerStartTime", new DateTime());
            }
            else
            {
                interval = DateTime.Now - _startTime;
            }

            // Addition to previous values
            var previousValue = Preferences.Get("timer", new DateTime()) - new DateTime(); // - new DateTime() is a trick to get a TimeSpan
            var subgroupPreviousValue = Preferences.Get(_groupNumber + "_" + _subgroupNumber, new DateTime()) - new DateTime(); // - new DateTime() is a trick to get a TimeSpan

            // Save new values
            Preferences.Set("timer", new DateTime() + (interval + previousValue)); // + new DateTime() is a trick to get a DateTime
            Preferences.Set(_groupNumber + "_" + _subgroupNumber, new DateTime() + (interval + subgroupPreviousValue)); // + new DateTime() is a trick to get a DateTime
            /*Preferences.Set("words_" + _groupNumber + "_" + _subgroupNumber, ((WordPageViewModel)BindingContext).UpdateCurrent + 1); // +1 for 1 to 50 and not 0 to 49 // For future use*/

            if (Device.RuntimePlatform == Device.iOS)
            {
                // Save state as not in a word page
                Preferences.Set("timerRunning", false);
            }

            // Save current group, subgroup, and word
            Application.Current.Properties["group"] = ((WordPageViewModel)BindingContext).UpdateGroupNumber;
            Application.Current.Properties["subgroup"] = ((WordPageViewModel)BindingContext).UpdateSubgroup;
            Application.Current.Properties["current"] = ((WordPageViewModel)BindingContext).UpdateCurrent;
            Application.Current.SavePropertiesAsync(); // To be sure it is saved
        }
    }
}
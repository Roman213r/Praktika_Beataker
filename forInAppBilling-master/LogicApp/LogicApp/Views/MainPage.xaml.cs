using LogicApp.Models;
using LogicApp.Services;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LogicApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        protected bool isLaunching = true;
        public IList<Group> GroupList { get; private set; }
        private int selectedGroup;

        public MainPage()
        {
            InitializeComponent();

            // Go directly to groups if resuming
            MessagingCenter.Subscribe<StartupPage>(this, "Resume", (sender) =>
            {
                OpenGroupPage();
            });

            // Create the list of groups
            GroupList = new List<Group>();
            for (int groupIndex = 0; groupIndex < Helpers.Data.GroupNames.Length; ++groupIndex)
            {
                GroupList.Add(new Group
                {
                    Id = groupIndex,
                    Name = Helpers.Data.GroupNames[groupIndex],
                    DescriptionTitle = Helpers.Data.GroupDescriptionTitles[groupIndex],
                    Description = Helpers.Data.GroupDescriptions[groupIndex],
                    GroupColor = Helpers.Data.GroupColors[groupIndex]
                });
            }
            BindingContext = this;
            // TODO: update images of groups if they are disabled

        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (!(args.SelectedItem is Group item))
                return;

            // Save the selected item to modify time when coming back
            selectedGroup = args.SelectedItemIndex;

            // Open the new page
            await Navigation.PushAsync(new SubgroupsPage(selectedGroup));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (isLaunching)
            {
                isLaunching = false;
                LaunchStartupPage();
            }
        }

        private async void LaunchStartupPage()
        {
            await Navigation.PushModalAsync(new StartupPage()); // await missing to make it run on iOS. TODO: fix it!
        }

        // When the resume button is pressed from startup page
        protected async void OpenGroupPage()
        {
            // Offer to resume if she was there once already
            if (Application.Current.Properties.ContainsKey("subgroup"))
            {
                var current = (int)Application.Current.Properties["current"];
                var subgroup = (int)Application.Current.Properties["subgroup"];
                var group = (int)Application.Current.Properties["group"];

                // Open the new page
                await Navigation.PushAsync(new WordPage(group, subgroup, Helpers.Data.SubgroupNames[group][subgroup], current, true), false);
            }
            else
            {
                await DisplayAlert(LogicApp.Resources.AppResources.NothingResume, LogicApp.Resources.AppResources.NothingResumeText, "OK");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LogicApp.Models;
using LogicApp.Views;
using LogicApp.ViewModels;
using Xamarin.Essentials;
using LogicApp.Services;
using Plugin.InAppBilling;

namespace LogicApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubgroupsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public IList<Subgroup> Subgroups { get; private set; }
        private int _groupNumber;
        private bool firstCall = true;
        private int selectedSubgroup;
        private Color GroupBackgoundColor;
        private Color GroupForegroundColor;

        public Color Background_color
        {
            protected set
            {
                GroupBackgoundColor = value;
            }

            get { return GroupBackgoundColor; }
        }
        public Color Foreground_color
        {
            protected set
            {
                GroupForegroundColor = value;
            }

            get { return GroupForegroundColor; }
        }

        public SubgroupsPage(int groupNumber)
        {
            InitializeComponent();
            _groupNumber = groupNumber;
            //BindingContext = viewModel = new ItemsViewModel();
            Title = LogicApp.Resources.AppResources.Group + " " + (groupNumber + 1);

            Subgroups = new List<Subgroup>();
            Background_color = Helpers.Data.SubgroupColors[groupNumber];
            Foreground_color = Helpers.Data.GroupColors[groupNumber];

            int currentNumber;
            int previousNumber = 0;
            for (int subgroupIndex = 0; subgroupIndex < Helpers.Data.SubgroupNames[_groupNumber].Length; ++subgroupIndex)
            {
                currentNumber = Helpers.Data.GroupImages[_groupNumber][subgroupIndex].Length;
                Subgroups.Add(new Subgroup
                {
                    Name = (subgroupIndex + 1) + ". " + Helpers.Data.SubgroupNames[_groupNumber][subgroupIndex],
                    SubgroupNumber = subgroupIndex,
                    WordsAccomplished = Preferences.Get("words_" + _groupNumber + "_" + subgroupIndex, 0),
                    NumberOfWords = currentNumber,
                    WordNumbers = "" + currentNumber, //(previousNumber + 1) + "-" + (previousNumber + currentNumber), // only show number of words
                    ImageUrl = Helpers.Data.SubgroupURLImages[_groupNumber][subgroupIndex],
                    TimeSpent = Preferences.Get(_groupNumber + "_" + subgroupIndex, new DateTime()) - new DateTime(),
                    SubgroupColor = Helpers.Data.SubgroupColors[groupNumber],
                    SubgroupMainColor = Helpers.Data.GroupColors[groupNumber]
                });
                previousNumber += currentNumber;
            }
            BindingContext = this;
            switch (_groupNumber)
            {
                case 0:
                    BrowseItemsPage.BackgroundColor = Color.FromHex("f4f9f5");
                    //TimeFrame.BackgroundColor = Color.FromHex("f4f9f5");
                    //ListFrameName.OutlineColor = Color.FromHex("f4f9f5");
                    break;
                case 1:
                    BrowseItemsPage.BackgroundColor = Color.FromHex("f4f4f9");
                    //TimeFrame.BackgroundColor = Color.FromHex("f4f4f9");
                    //ListFrameName.OutlineColor = Color.FromHex("f4f4f9");
                    break;
                default:
                    BrowseItemsPage.BackgroundColor = Color.FromHex("fff7f8");
                    //TimeFrame.BackgroundColor = Color.FromHex("fff7f8");
                    //ListFrameName.OutlineColor = Color.MistyRose;
                    break;
            }
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Subgroup;
            if (item == null)
                return;

            // Save the selected item to modify time when coming back
            selectedSubgroup = args.SelectedItemIndex;

            if (selectedSubgroup > 0)
            {
#if !DEBUG
                bool isPurchase = await DependencyService.Get<InAppBillingService>().WasItemPurchased($"all_groups", ItemType.InAppPurchase);
                bool isSubsribtion = await DependencyService.Get<InAppBillingService>().WasItemPurchased("full_monthly", ItemType.Subscription);
#else
                bool isPurchase = true;
                bool isSubsribtion = true;
#endif
                if (!isPurchase || !isSubsribtion)
                {
                    await Navigation.PushModalAsync(new InAppPage());
                    return;
                }
            }

            // Open the new page
            await Navigation.PushAsync(new WordPage(_groupNumber, item.SubgroupNumber, item.Name, (item.WordsAccomplished == 0) ? 0 : 0/*item.WordsAccomplished - 1*/, false)); // TODO: if resume were left

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

            // Show description if needed
            if (firstCall)
            {
                ShowGroupDescription();
                firstCall = false;
            }
            else
            {
                // Upadate value of the latest selected item
                Subgroups[selectedSubgroup].TimeSpent = Preferences.Get(_groupNumber + "_" + selectedSubgroup, new DateTime()) - new DateTime();
                //Subgroups[selectedSubgroup].WordsAccomplished = Preferences.Get("words_" + _groupNumber + "_" + selectedSubgroup, 0); // For future use
            }
        }

        // Show the description of the group as long as it is not marked as never show again.
        protected async void ShowGroupDescription()
        {
            if (!Application.Current.Properties.ContainsKey("groupDescription" + _groupNumber)) // It was never marked as not showing
            {
                String groupDescription;
                switch (_groupNumber)
                {
                    case 0:
                        groupDescription = LogicApp.Resources.AppResources.DescriptionGroup1;
                        break;
                    case 1:
                        groupDescription = LogicApp.Resources.AppResources.DescriptionGroup2;
                        break;
                    case 2:
                        groupDescription = LogicApp.Resources.AppResources.DescriptionGroup3;
                        break;
                    case 3:
                        groupDescription = LogicApp.Resources.AppResources.DescriptionGroup4;
                        break;
                    case 4:
                        groupDescription = LogicApp.Resources.AppResources.DescriptionGroup5;
                        break;
                    default:
                        groupDescription = "Problem...";
                        break;
                }

                var answer = await DisplayAlert(LogicApp.Resources.AppResources.GroupeDescription, groupDescription, LogicApp.Resources.AppResources.NeverShowAgain, LogicApp.Resources.AppResources.OK);
                if (answer)
                {
                    // Never show again
                    Application.Current.Properties["groupDescription" + _groupNumber] = 0;
                    await Application.Current.SavePropertiesAsync(); // To be sure it is saved
                }
            }
        }

        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            bool isAllGroupPurchased = await DependencyService.Get<InAppBillingService>().WasItemPurchased($"full_monthly", ItemType.Subscription);

            if (!isAllGroupPurchased)
                await DependencyService.Get<InAppBillingService>().PurchaseItem($"full_monthly", ItemType.Subscription);
        }
    }
}
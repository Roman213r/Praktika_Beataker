using System;
using System.Collections.Generic;
using LogicApp.Services;
using Plugin.InAppBilling;
using Xamarin.Forms;

namespace LogicApp.Views
{
    public partial class InAppPage : ContentPage
    {
        public InAppPage()
        {
            InitializeComponent();
        }

        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (await DependencyService.Get<InAppBillingService>().PurchaseItem($"full_monthly", ItemType.Subscription)) await App.DownloadContentAsync();
        }

        async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            if (await DependencyService.Get<InAppBillingService>().PurchaseItem($"all_groups", ItemType.InAppPurchase)) await App.DownloadContentAsync();
        }

        async void TapGestureRecognizer_Tapped_2(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}

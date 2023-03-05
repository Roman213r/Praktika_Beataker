using LogicApp.Services;
using LogicApp.Views;
using Plugin.FirebaseStorage;
using System;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LogicApp
{
    public partial class App : Application
    {


        public App()
        {
            InitializeComponent();

            DependencyService.Register<InAppBillingService>();

            MainPage = new NavigationPage(new MainPage());
            //Resources.AppResources.Culture = CrossMultilingual.Current.DeviceCultureInfo;
        }

        protected override async void OnStart()
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                // Application restarted, so clear running status if any
                if (Preferences.Get("timerRunning", false)) // Useful to test to avoid writing everytime
                {
                    Preferences.Set("timerRunning", false);
                }
            }
#if !DEBUG
            bool isPurchase = await DependencyService.Get<InAppBillingService>().WasItemPurchased($"all_groups", ItemType.InAppPurchase);
            bool isSubsribtion = await DependencyService.Get<InAppBillingService>().WasItemPurchased("full_monthly", ItemType.Subscription);
#else
            bool isPurchase = true;
            bool isSubsribtion = true;
#endif
            if (isPurchase || isSubsribtion) await DownloadContentAsync();
        }

        protected override void OnSleep()
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                // If it was on word page
                if (Preferences.Get("timerRunning", false))
                {
                    // Get the time spent already
                    TimeSpan interval = DateTime.Now - Preferences.Get("timerStartTime", DateTime.Now);

                    // Save timer new value for main timer
                    Preferences.Set("timer", new DateTime() + (interval + (Preferences.Get("timer", new DateTime()) - new DateTime()))); // + new DateTime() is a trick to get a DateTime

                    // Save timer for current word
                    var subGroupNumber = Preferences.Get("subGroupNumber", "0-0");
                    var subgroupPreviousValue = Preferences.Get(subGroupNumber, new DateTime()) - new DateTime();
                    Preferences.Set(subGroupNumber, new DateTime() + (interval + subgroupPreviousValue)); // + new DateTime() is a trick to get a DateTime
                }
            }
        }

        protected override async void OnResume()
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                // If it was on word page before putting to background
                if (Preferences.Get("timerRunning", false))
                {
                    // Start the timer
                    Preferences.Set("timerStartTime", DateTime.Now);
                }
            }
#if !DEBUG
            bool isPurchase = await DependencyService.Get<InAppBillingService>().WasItemPurchased($"all_groups", ItemType.InAppPurchase);
            bool isSubsribtion = await DependencyService.Get<InAppBillingService>().WasItemPurchased("full_monthly", ItemType.Subscription);
#else
            bool isPurchase = true;
            bool isSubsribtion = true;
#endif
            if (isPurchase || isSubsribtion) await DownloadContentAsync();
        }

        public static async Task DownloadContentAsync()
        {
            string premiumContentPath = Path.Combine(FileSystem.AppDataDirectory, "premium_content/");
            string metaFilePath = Path.Combine(premiumContentPath, "meta.info");
            string remoteFileName = "premium_content.zip";
            string tmpFile = Path.Combine(FileSystem.CacheDirectory, remoteFileName);

            IStorageReference reference = CrossFirebaseStorage.Current.Instance.RootReference.Child(remoteFileName);
            IStorageMetadata metadata = await reference.GetMetadataAsync();
            long ticks = metadata.CreationTime.Ticks;

            if (File.Exists(metaFilePath))
            {
                long time = long.Parse(await File.ReadAllTextAsync(metaFilePath));

                if (ticks != time)
                    Directory.Delete(premiumContentPath, true);
                else
                    return;
            }

            if (!Directory.Exists(premiumContentPath)) _ = Directory.CreateDirectory(premiumContentPath);

            await reference.GetFileAsync(tmpFile);
            ZipFile.ExtractToDirectory(tmpFile, premiumContentPath, true);

            await File.WriteAllTextAsync(metaFilePath, ticks.ToString());
        }
    }
}

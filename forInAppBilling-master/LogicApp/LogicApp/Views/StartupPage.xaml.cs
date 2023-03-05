using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace LogicApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StartupPage : ContentPage
	{
        private TimeSpan _interval;
		public StartupPage ()
		{

            TimeSpent = Preferences.Get("timer", new DateTime()) - new DateTime();
            this.BindingContext = this;
            InitializeComponent();
		}

        private async void OnResumeClicked(object sender, EventArgs e)
        {
            // Inform that resume was clicked
            MessagingCenter.Send<StartupPage>(this, "Resume");
            await Navigation.PopModalAsync();
        }

        private async void OnMenuClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void OnGoalsMenuClicked(object sender, EventArgs e)
        {
            await DisplayAlert(LogicApp.Resources.AppResources.Goals, LogicApp.Resources.AppResources.GoalsDescription1 + "\n\n" + LogicApp.Resources.AppResources.GoalsDescription2 + "\n\n" + LogicApp.Resources.AppResources.GoalsDescription3, LogicApp.Resources.AppResources.OK);
        }

        private async void OnDescriptionMenuClicked(object sender, EventArgs e)
        {
            await DisplayAlert(LogicApp.Resources.AppResources.MainDescription, LogicApp.Resources.AppResources.MainDescription1 + "\n\n" + LogicApp.Resources.AppResources.MainDescription2 + "\n\n" + LogicApp.Resources.AppResources.MainDescription3, LogicApp.Resources.AppResources.OK);
        }

        public TimeSpan TimeSpent
        {
            get { return _interval; }
            set { _interval = value; }
        }
        public String TimeSpentString
        {
            get 
            {
                /*if (_interval.Hours > 23) return _interval.Days + LogicApp.Resources.AppResources.Days + _interval.ToString(@"h\:mm\:ss");
                else return _interval.ToString(@"h\:mm\:ss"); */
                return string.Format("{0}:{1}:{2}", (int)_interval.TotalHours, _interval.Minutes, _interval.Seconds); // We want hours not days
            }
            set { }
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ExaminationsPage());
        }
    }
}
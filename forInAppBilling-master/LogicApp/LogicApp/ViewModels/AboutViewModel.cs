using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace LogicApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
#pragma warning disable CS0618 // Le type ou le membre est obsolète
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
#pragma warning restore CS0618 // Le type ou le membre est obsolète
        }

        public ICommand OpenWebCommand { get; }
    }
}
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace PryFoodRankApp.ViewModels
{
    class MainScreenViewModel : BaseViewModel
    {
        public MainScreenViewModel()
        {
            Title = "Main Screen";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        /// <summary>
        /// Command to open browser to xamarin.com
        /// </summary>
        public ICommand OpenWebCommand { get; }
    }
}


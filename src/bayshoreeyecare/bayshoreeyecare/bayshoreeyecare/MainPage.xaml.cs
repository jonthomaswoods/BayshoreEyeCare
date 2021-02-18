using bayshoreeyecare.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace bayshoreeyecare
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //if (Device.RuntimePlatform == Device.Android)
            //{
            //    SplashIcon.Source = "@drawable/bayshoresplash.png";
            //}

            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ScaleIcon();
        }

        private async void ScaleIcon()
        {
            // wait until the UI is present
            //await Task.Delay(300);

            //// animate the splash logo
            //await SplashIcon.ScaleTo(0.5, 500, Easing.CubicInOut);
            //var animationTasks = new[]{
            //    SplashIcon.ScaleTo(100.0, 1000, Easing.CubicInOut),
            //    SplashIcon.FadeTo(0, 700, Easing.CubicInOut)
            //};
            //await Task.WhenAll(animationTasks);

            //// navigate to main page
            //await RootPage.NavigateFromMenu(3);
            //await Navigation.PushAsync(new NavigationPage(new MainPage()));
            await Navigation.PushAsync(new Home());
        }
    }
}

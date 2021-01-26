using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bayshoreeyecare.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }
        private void btnFacebook_Clicked(object sender, EventArgs e)
        {

            try
            {
                var uri = new Uri("https://www.facebook.com/BayshoreEye/");
                Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team on the 'Contact' page. The error:" + ex.ToString(), "Cancel");
            }
        }

        private void btnWeb_Clicked(object sender, EventArgs e)
        {

            try
            {
                var uri = new Uri("https://www.bayshoreeyecare.net/");
                Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team on the 'Contact' page. The error:" + ex.ToString(), "Cancel");
            }
        }

        private async void btnEmergencyContact_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new EmergencyContact());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team on the 'Contact' page. The error:" + ex.Message.ToString(), "Cancel");
            }
        }

        private async void btnCpnRbt_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new CouponsandRebates());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team on the 'Contact' page. The error:" + ex.Message.ToString(), "Cancel");
            }
        }

        private async void btnContact_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Contact());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team on the 'Contact' page. The error:" + ex.Message.ToString(), "Cancel");
            }

        }

        private async void btnSales_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Products());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team on the 'Contact' page. The error:" + ex.Message.ToString(), "Cancel");
            }

        }
    }
}
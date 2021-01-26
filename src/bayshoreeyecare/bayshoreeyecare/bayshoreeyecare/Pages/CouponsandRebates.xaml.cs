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
    public partial class CouponsandRebates : ContentPage
    {
        public CouponsandRebates()
        {
            InitializeComponent();
        }

        private void btnBauschLomb_Clicked(object sender, EventArgs e)
        {
            try
            {
                var uri = new Uri("https://www.bausch.com/couponsandoffers");
                Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team. The error:" + ex.ToString(), "Cancel");
            }
        }

        private void btnSystane_Clicked(object sender, EventArgs e)
        {
            try
            {
                var uri = new Uri("https://systane.myalcon.com/eye-care/systane/coupon/");
                Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team. The error:" + ex.ToString(), "Cancel");
            }
        }

        private void btnCooperVision_Clicked(object sender, EventArgs e)
        {
            try
            {
                var uri = new Uri("https://www.coopervisionpromotions.com/");
                Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team. The error:" + ex.ToString(), "Cancel");
            }
        }

        private void btnMyACUVUE_Clicked(object sender, EventArgs e)
        {
            try
            {
                var uri = new Uri("https://www.acuvue.com/myacuvue-rewards-benefits");
                Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team. The error:" + ex.ToString(), "Cancel");
            }
        }

        private void btnBauschLombRebates_Clicked(object sender, EventArgs e)
        {
            try
            {
                var uri = new Uri("https://bauschrewards.com/");
                Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team. The error:" + ex.ToString(), "Cancel");
            }
        }

        private void btnAlcon_Clicked(object sender, EventArgs e)
        {
            try
            {
                var uri = new Uri("https://alconchoice.com/");
                Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team. The error:" + ex.ToString(), "Cancel");
            }
        }
    }
}
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
    public partial class Products : ContentPage
    {
        public Products()
        {
            InitializeComponent();
        }

        private void btnHydroEye_Clicked(object sender, EventArgs e)
        {
            try
            {
                var uri = new Uri("https://www.sciencebasedhealth.com/HydroEye-Powerful-Dry-Eye-Relief-P43.aspx");
                Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team. The error:" + ex.ToString(), "Cancel");
            }
        }

        private void btnBlephadex_Clicked(object sender, EventArgs e)
        {
            try
            {
                var uri = new Uri("https://www.blephadex.com/");
                Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team. The error:" + ex.ToString(), "Cancel");
            }
        }

        private void btnMacuHealth_Clicked(object sender, EventArgs e)
        {
            try
            {
                var uri = new Uri("https://www.macuhealth.com/");
                Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team. The error:" + ex.ToString(), "Cancel");
            }
        }
    }
}
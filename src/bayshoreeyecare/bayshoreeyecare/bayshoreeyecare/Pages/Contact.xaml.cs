using bayshoreeyecare.Popup;
using Rg.Plugins.Popup.Extensions;
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
    public partial class Contact : ContentPage
    {
        public Contact()
        {
            InitializeComponent();

            try
            {

                btnNumber.Text = "Office Phone: 941-751-4668";

                var hours = new List<string>();
                hours.Add("Saturday  Closed");
                hours.Add("Sunday  Closed");
                hours.Add("Monday  8:30 AM–5:30 PM");
                hours.Add("Tuesday  8:30 AM–5:30 PM");
                hours.Add("Wednesday  8:30 AM–5:30 PM");
                hours.Add("Thursday  8:30 AM–5:30 PM");
                hours.Add("Friday  8:30 AM–12:00 PM");

                var day = DateTime.Now.DayOfWeek;

                foreach (var firstdays in hours)
                {
                    int index = hours.FindIndex(x => x.Contains(day.ToString()));
                    if (firstdays.Contains(day.ToString()) && index != -1)
                    {
                        lblDay1.Text = firstdays;

                        if (index == 0)
                        {
                            foreach (var days in hours)
                            {
                                int curindex = hours.FindIndex(x => x.Contains(days.ToString()));

                                if (curindex == 1)
                                {
                                    lblDay2.Text = days.ToString();
                                }
                                else if (curindex == 2)
                                {
                                    lblDay3.Text = days.ToString();
                                }
                                else if (curindex == 3)
                                {
                                    lblDay4.Text = days.ToString();
                                }
                                else if (curindex == 4)
                                {
                                    lblDay5.Text = days.ToString();
                                }
                                else if (curindex == 5)
                                {
                                    lblDay6.Text = days.ToString();
                                }
                                else if (curindex == 6)
                                {
                                    lblDay7.Text = days.ToString();
                                }
                            }
                        }
                        else
                        {
                            foreach (var days in hours.Take(index))
                            {
                                int curindex = hours.FindIndex(x => x.Contains(days.ToString()));

                                if ((curindex - 6) == ((index - 6) - 6))
                                {
                                    lblDay2.Text = days.ToString();
                                }
                                else if ((curindex - 6) == ((index - 5) - 6))
                                {
                                    lblDay3.Text = days.ToString();
                                }
                                else if ((curindex - 6) == ((index - 4) - 6))
                                {
                                    lblDay4.Text = days.ToString();
                                }
                                else if ((curindex - 6) == ((index - 3) - 6))
                                {
                                    lblDay5.Text = days.ToString();
                                }
                                else if ((curindex - 6) == ((index - 2) - 6))
                                {
                                    lblDay6.Text = days.ToString();
                                }
                                else if ((curindex - 6) == ((index - 1) - 6))
                                {
                                    lblDay7.Text = days.ToString();
                                }

                            }
                            foreach (var days in hours)
                            {
                                int curindex = hours.FindIndex(x => x.Contains(days.ToString()));
                                if (index == 6)
                                {
                                    if (curindex == 0)
                                    {
                                        lblDay2.Text = days.ToString();
                                    }
                                    else if (curindex == 1)
                                    {
                                        lblDay3.Text = days.ToString();
                                    }
                                    else if (curindex == 2)
                                    {
                                        lblDay4.Text = days.ToString();
                                    }
                                    else if (curindex == 3)
                                    {
                                        lblDay4.Text = days.ToString();
                                    }
                                    else if (curindex == 4)
                                    {
                                        lblDay6.Text = days.ToString();
                                    }
                                    else if (curindex == 5)
                                    {
                                        lblDay7.Text = days.ToString();
                                    }
                                }
                                else
                                {
                                    if ((curindex - 6) == ((index + 1) - 6))
                                    {
                                        lblDay2.Text = days.ToString();
                                    }
                                    else if ((curindex - 6) == ((index + 2) - 6))
                                    {
                                        lblDay3.Text = days.ToString();
                                    }
                                    else if ((curindex - 6) == ((index + 3) - 6))
                                    {
                                        lblDay4.Text = days.ToString();
                                    }
                                    else if ((curindex - 6) == ((index + 4) - 6))
                                    {
                                        lblDay5.Text = days.ToString();
                                    }
                                    else if ((curindex - 6) == ((index + 5) - 6))
                                    {
                                        lblDay6.Text = days.ToString();
                                    }
                                    else if ((curindex - 6) == ((index + 6) - 6))
                                    {
                                        lblDay7.Text = days.ToString();
                                    }
                                }
                            }
                        }
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team on the 'Contact' page. The error:" + ex.Message.ToString(), "Cancel");
            }
        }

        private async void btnDirections_Clicked(object sender, EventArgs e)
        {
            try
            {


                var location = new Location(27.440562, -82.587948);
                var options = new MapLaunchOptions { Name = "Bayshore Eyecare" };

                await Map.OpenAsync(location, options);

                //if (Device.RuntimePlatform == Device.iOS)
                //{
                //    // https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
                //    await Launcher.OpenAsync("http://maps.apple.com/?q=5632+26th+Street+West+Bradenton+FL");
                //}
                //else if (Device.RuntimePlatform == Device.Android)
                //{
                //    // open the maps app directly
                //    await Launcher.OpenAsync("geo:0,0?q=5632+26th+Street+West+Bradenton+FL");
                //}
                //else if (Device.RuntimePlatform == Device.UWP)
                //{
                //    await Launcher.OpenAsync("bingmaps:?where=5632 26th Street West Bradenton FL");
                //}

            }
            catch(Exception ex)
            {
                await DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team on the 'Contact' page. The error:" + ex.Message.ToString(), "Cancel");
            }

        }

        private void btnNumber_Clicked(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open("941-751-4668");
            }
            catch (Exception ex)
            {
                DisplayAlert("No Phone", "There is no phone dialer on this device.", "Cancel");
            }

        }

        private void btnAppEmail_Clicked(object sender, EventArgs e)
        {
            //open email addressed to crux resolutions
            try
            {
                Navigation.PushPopupAsync(new ErrorContactPopup());
                //var address = "support@cruxresolutions.com";
                //Device.OpenUri(new Uri($"mailto:{address}"));
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team on the 'Contact' page. The error:" + ex.Message.ToString(), "Cancel");
            }
            
        }
    }
}
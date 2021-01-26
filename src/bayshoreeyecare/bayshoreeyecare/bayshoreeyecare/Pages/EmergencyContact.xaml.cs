using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Mail;
using Xamarin.Essentials;
using System.Net;

namespace bayshoreeyecare.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmergencyContact : ContentPage
    {
        public EmergencyContact()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(entPhone.Text) || !string.IsNullOrEmpty(entName.Text))
                {
                    //**** awaits suck
                    var rand = new Random();
                    var recaptcha = rand.Next(1000, 9999);
                    var res = await DisplayPromptAsync("Human Verification", "Enter the value: " + recaptcha.ToString(), "Confirm", "Cancel", null, 4, Keyboard.Numeric, null);
                    if (!string.IsNullOrEmpty(res) && res.ToString() == recaptcha.ToString())
                    {
                        aiLayout.IsVisible = true;
                        activity.IsEnabled = true;
                        activity.IsRunning = true;
                        activity.IsVisible = true;
                        await Task.Delay(1000);
                        SendSMS();
                    }
                    else
                    {
                        aiLayout.IsVisible = false;
                        activity.IsEnabled = false;
                        activity.IsRunning = false;
                        activity.IsVisible = false;
                        await DisplayAlert("Not Verified", "Human verification validation failed", "Cancel");
                    }

                }
                else
                {
                    aiLayout.IsVisible = false;
                    activity.IsEnabled = false;
                    activity.IsRunning = false;
                    activity.IsVisible = false;
                    await DisplayAlert("Empty Field(s)", "Please make sure to entered your name and phone number, so the doctor can contact you back.", "Cancel");
                }
            }
            catch (Exception ex)
            {
                aiLayout.IsVisible = false;
                activity.IsEnabled = false;
                activity.IsRunning = false;
                activity.IsVisible = false;
                await DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team on the 'Contact' page. The error:" + ex.Message.ToString(), "Cancel");
            }

        }

        private async void SendSMS()
        {
            try
            {
                var current = Connectivity.NetworkAccess;

                if (current == NetworkAccess.Internet)
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("support@cruxresolutions.com");
                    mail.To.Add("9414480886@vtext.com");
                    mail.Subject = "Emergecy Contact";
                    if (!string.IsNullOrEmpty(entDesc.Text))
                    {
                        mail.Body = "    Name: " + entName.Text + "    Phone: " + entPhone.Text + "    Description: " + entDesc.Text + "    Date: " + DateTime.Now.ToLongDateString();
                    }
                    else
                    {
                        mail.Body = "    Name: " + entName.Text + "    Phone: " + entPhone.Text + "    Date: " + DateTime.Now.ToLongDateString();

                    }
                    SmtpServer.Port = 587;
                    SmtpServer.Host = "smtp.gmail.com";
                    SmtpServer.EnableSsl = true;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("support@cruxresolutions.com", "CodeCode77");

                    SmtpServer.Send(mail);
                    mail.Dispose();
                    SmtpServer.Dispose();

                    aiLayout.IsVisible = false;
                    activity.IsEnabled = false;
                    activity.IsRunning = false;
                    activity.IsVisible = false;
                    await DisplayAlert("Success", "Text message sent to doctors, please be patient for a response.", "Okay");

                }
                else
                {
                    aiLayout.IsVisible = false;
                    activity.IsEnabled = false;
                    activity.IsRunning = false;
                    activity.IsVisible = false;
                    await DisplayAlert("Connection", "No internet connection. Please try again.", "Okay");
                }
            }

            catch (Exception ex)
            {
                aiLayout.IsVisible = false;
                activity.IsEnabled = false;
                activity.IsRunning = false;
                activity.IsVisible = false;
                await DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team on the 'Contact' page. The error:" + ex.Message.ToString(), "Cancel");
            }
        
           
        }

    }
}
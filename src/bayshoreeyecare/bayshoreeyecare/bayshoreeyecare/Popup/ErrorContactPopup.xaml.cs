using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bayshoreeyecare.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ErrorContactPopup : Rg.Plugins.Popup.Pages.PopupPage
    {
        public ErrorContactPopup()
        {
            InitializeComponent();
        }

        private void btnSend_Clicked(object sender, EventArgs e)
        {
            string useremail = entUserEmail.Text.ToString();
            string message = entMessage.Text.ToString();
            if (IsValidEmail(useremail))
            {
                if (!string.IsNullOrEmpty(useremail) && !string.IsNullOrEmpty(message))
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    mail.From = new MailAddress("support@cruxresolutions.com");
                    mail.To.Add("support@cruxresolutions.com");
                    mail.Subject = "Bayshore Eye Care User Error";
                    mail.Body = useremail + ": " +  message;
                    SmtpServer.Port = 587;
                    SmtpServer.Host = "smtp.gmail.com";
                    SmtpServer.EnableSsl = true;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("support@cruxresolutions.com", "CodeCode77");

                    SmtpServer.Send(mail);
                    mail.Dispose();
                    SmtpServer.Dispose();

                    DisplayAlert("Success", "Email sent to app team, please be patient for a response.", "Okay");
                    CloseAllPopup();
                }
                else
                {
                    DisplayAlert("Incomplete Form", "Please enter your email and a message in order to email the app support team.", "Cancel");
                }
            }
            else
            {
                DisplayAlert("Invalid Email", "Please enter your valid email.", "Cancel");
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void OnCancel(object sender, EventArgs e)
        {
            try
            {
                CloseAllPopup();
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Please take a screenshot of the error and send an email to the App team on the 'Contact' page. The error:" + ex.Message.ToString(), "Cancel");
            }
        }
        private async void CloseAllPopup()
        {
            await PopupNavigation.Instance.PopAllAsync();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        // ### Methods for supporting animations in your popup page ###

        // Invoked before an animation appearing
        protected override void OnAppearingAnimationBegin()
        {
            base.OnAppearingAnimationBegin();
        }

        // Invoked after an animation appearing
        protected override void OnAppearingAnimationEnd()
        {
            base.OnAppearingAnimationEnd();
        }

        // Invoked before an animation disappearing
        protected override void OnDisappearingAnimationBegin()
        {
            base.OnDisappearingAnimationBegin();
        }

        // Invoked after an animation disappearing
        protected override void OnDisappearingAnimationEnd()
        {
            base.OnDisappearingAnimationEnd();
        }

        protected override Task OnAppearingAnimationBeginAsync()
        {
            return base.OnAppearingAnimationBeginAsync();
        }

        protected override Task OnAppearingAnimationEndAsync()
        {
            return base.OnAppearingAnimationEndAsync();
        }

        protected override Task OnDisappearingAnimationBeginAsync()
        {
            return base.OnDisappearingAnimationBeginAsync();
        }

        protected override Task OnDisappearingAnimationEndAsync()
        {
            return base.OnDisappearingAnimationEndAsync();
        }

        // ### Overrided methods which can prevent closing a popup page ###

        // Invoked when a hardware back button is pressed
        protected override bool OnBackButtonPressed()
        {
            // Return true if you don't want to close this popup page when a back button is pressed
            return base.OnBackButtonPressed();
        }

        // Invoked when background is clicked
        protected override bool OnBackgroundClicked()
        {
            // Return false if you don't want to close this popup page when a background of the popup page is clicked
            return base.OnBackgroundClicked();
        }
    }
}
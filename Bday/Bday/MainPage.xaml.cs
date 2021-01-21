using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Messaging;

namespace Bday
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Holiday.Items.Add("Halloween");
            Holiday.Items.Add("Easter");
            Holiday.Items.Add("Christmas");
            Holiday.Items.Add("New Year");
            Holiday.Items.Add("Birthday");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (Holiday.SelectedItem == "New Year")
            {
                var smsMessenger = CrossMessaging.Current.SmsMessenger;
                if (smsMessenger.CanSendSms)
                    smsMessenger.SendSms(phNum.Text, "Happy New Year!");
            }
            if (Holiday.SelectedItem == "Halloween")
            {
                var smsMessenger = CrossMessaging.Current.SmsMessenger;
                if (smsMessenger.CanSendSms)
                    smsMessenger.SendSms(phNum.Text, "Happy Halloween!");
            }
            if (Holiday.SelectedItem == "Easter")
            {
                var smsMessenger = CrossMessaging.Current.SmsMessenger;
                if (smsMessenger.CanSendSms)
                    smsMessenger.SendSms(phNum.Text, "Happy Easter!");
            }
            if (Holiday.SelectedItem == "Christmas")
            {
                var smsMessenger = CrossMessaging.Current.SmsMessenger;
                if (smsMessenger.CanSendSms)
                    smsMessenger.SendSms(phNum.Text, "Merry Christmas!");
            }
            if (Holiday.SelectedItem == "Birthday")
            {
                var smsMessenger = CrossMessaging.Current.SmsMessenger;
                if (smsMessenger.CanSendSms)
                    smsMessenger.SendSms(phNum.Text, "Happy Birthday!");
            }
        }

        private void custom_Clicked(object sender, EventArgs e)
        {
            var smsMessenger = CrossMessaging.Current.SmsMessenger;
            if (smsMessenger.CanSendSms)
                smsMessenger.SendSms(phNum.Text,own.Text);
        }
    }
}

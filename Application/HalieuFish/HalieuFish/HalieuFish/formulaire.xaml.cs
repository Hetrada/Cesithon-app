using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace HalieuFish
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class formulaire : ContentPage
    {
        public formulaire()
        {
            InitializeComponent();
        }

        private void box1(object sender, CheckedChangedEventArgs e)
        {

        }

        private void Active1(object sender, EventArgs e)
        {
            original.IsVisible = false;
            croix.IsVisible = true;            
        }

        private void Active2(object sender, EventArgs e)
        {
            original2.IsVisible = false;
            croix2.IsVisible = true;
        }

        private void box2(object sender, CheckedChangedEventArgs e)
        {

        }

        private void box3(object sender, CheckedChangedEventArgs e)
        {

        }

        private void Active3(object sender, EventArgs e)
        {
            original3.IsVisible = false;
            croix3.IsVisible = true;
        }

        private void box4(object sender, CheckedChangedEventArgs e)
        {

        }

        private void Active4(object sender, EventArgs e)
        {
            original4.IsVisible = false;
            croix4.IsVisible = true;
        }

        private void box5(object sender, CheckedChangedEventArgs e)
        {

        }

        private void Active5(object sender, EventArgs e)
        {
            original5.IsVisible = false;
            croix5.IsVisible = true;
        }

        private void Cacher(object sender, EventArgs e)
        {
            original.IsVisible = true;
            croix.IsVisible = false;

            original2.IsVisible = true;
            croix2.IsVisible = false;

            original3.IsVisible = true;
            croix3.IsVisible = false;

            original4.IsVisible = true;
            croix4.IsVisible = false;

            original5.IsVisible = true;
            croix5.IsVisible = false;
        }

        private void SendNudes(object sender, EventArgs e)
        {
            EmailMessage smsMessage = new EmailMessage
            {
                Subject = "Rapport pêche Bateau : BL934836",
                Body = "Bonjour voici le rapport détaillé de la pêche du 07/11/2021\n" +
                "",
                To = { "baptistelerate@gmail.com" }

            };
            Task slt = Email.ComposeAsync(smsMessage);
        }
    }
}
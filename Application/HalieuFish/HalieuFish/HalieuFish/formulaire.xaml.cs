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
        bool box1M = false;
        bool box1Nm = false;
        bool box1Hq = false;

        bool box2M = false;
        bool box2Nm = false;
        bool box2Hq = false;

        bool box3M = false;
        bool box3Nm = false;
        bool box3Hq = false;

        bool box4M = false;
        bool box4Nm = false;
        bool box4Hq = false;

        bool box5M = false;
        bool box5Nm = false;
        bool box5Hq = false;
        public formulaire()
        {
            InitializeComponent();

            
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

        

        

        private void Active3(object sender, EventArgs e)
        {
            original3.IsVisible = false;
            croix3.IsVisible = true;
        }

       

        private void Active4(object sender, EventArgs e)
        {
            original4.IsVisible = false;
            croix4.IsVisible = true;
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

        private void box1_maille(object sender, CheckedChangedEventArgs e)
        {
            box1M = !box1M;
        }

        private void box1_nm(object sender, CheckedChangedEventArgs e)
        {
            box1Nm = !box1Nm;
        }

        private void box1_hq(object sender, CheckedChangedEventArgs e)
        {
            box1Hq = !box1Hq;
        }

        private void box2_maille(object sender, CheckedChangedEventArgs e)
        {
            box2M = !box2M;
        }

        private void box2_nm(object sender, CheckedChangedEventArgs e)
        {
            box2Nm = !box2Nm;
        }

        private void box2_hq(object sender, CheckedChangedEventArgs e)
        {
            box2Hq = !box2Hq;
        }

        private void box3_maille(object sender, CheckedChangedEventArgs e)
        {
            box3M = !box3M;
        }

        private void box3_nm(object sender, CheckedChangedEventArgs e)
        {
            box3Nm = !box3Nm;
        }

        private void box3_hq(object sender, CheckedChangedEventArgs e)
        {
            box3Hq = !box3Hq;
        }

        private void box4_maille(object sender, CheckedChangedEventArgs e)
        {
            box4M = !box4M;
        }

        private void box4_nm(object sender, CheckedChangedEventArgs e)
        {
            box4Nm = !box4Nm;
        }

        private void box4_hq(object sender, CheckedChangedEventArgs e)
        {
            box4Hq = !box4Hq;
        }

        private void box5_maille(object sender, CheckedChangedEventArgs e)
        {
            box5M = !box5M;
        }

        private void box5_nm(object sender, CheckedChangedEventArgs e)
        {
            box5Nm = !box5Nm;
        }

        private void box5_hq(object sender, CheckedChangedEventArgs e)
        {
            box5Hq = !box5Hq;
        }
    }
}
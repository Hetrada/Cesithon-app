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
        int masseM1;
        bool box1Nm = false;
        int masseNm1;
        bool box1Hq = false;
        int masseHq1;

        bool box2M = false;
        int masseM2;
        bool box2Nm = false;
        int masseNm2;
        bool box2Hq = false;
        int masseHq2;

        bool box3M = false;
        int masseM3;
        bool box3Nm = false;
        int masseNm3;
        bool box3Hq = false;
        int masseHq3;

        bool box4M = false;
        int masseM4;
        bool box4Nm = false;
        int masseNm4;
        bool box4Hq = false;
        int masseHq4;

        bool box5M = false;
        int masseM5;
        bool box5Nm = false;
        int masseNm5;
        bool box5Hq = false;
        int masseHq5;
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
        public void seeDataForm()
        {
            
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

        private void okP1(object sender, TextChangedEventArgs e)
        {

        }

        private void MP1Ma(object sender, EventArgs e)
        {

        }

        private void MP1Nm(object sender, EventArgs e)
        {

        }

        private void MP1Hq(object sender, EventArgs e)
        {

        }

        private void Mp2Ma(object sender, EventArgs e)
        {

        }

        private void Mp2Nm(object sender, EventArgs e)
        {

        }

        private void Mp2Hq(object sender, EventArgs e)
        {

        }

        private void Mp3Ma(object sender, EventArgs e)
        {

        }

        private void Mp3Nm(object sender, EventArgs e)
        {

        }

        private void Mp3Hq(object sender, EventArgs e)
        {

        }

        private void Mp4Ma(object sender, EventArgs e)
        {

        }

        private void Mp4Nm(object sender, EventArgs e)
        {

        }

        private void Mp4Hq(object sender, EventArgs e)
        {

        }

        private void Mp5Ma(object sender, EventArgs e)
        {

        }

        private void Mp5Nm(object sender, EventArgs e)
        {

        }

        private void Mp5Hq(object sender, EventArgs e)
        {

        }
    }
}
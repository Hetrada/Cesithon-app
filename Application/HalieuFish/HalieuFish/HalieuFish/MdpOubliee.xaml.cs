using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HalieuFish
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        string adresseTarget;
        public Page2()
        {
            InitializeComponent();
        }


        private void MailMDP(object sender, EventArgs e)
        {
            if (adresseTarget == null) popUp();
            else
            {
                EmailMessage smsMessage = new EmailMessage
                {
                    Subject = "Mot de passe oublié",
                    Body = "voici votre mot de passe : testP",
                    To = { adresseTarget }

                };
                Task slt = Email.ComposeAsync(smsMessage);
            }
    
        }
            
        public async void popUp()
        {
            await DisplayAlert("Erreur", "Veuillez rentrer une adresse mail", "OK");
        }
        public void OnEntryCompleted(object sender, EventArgs e)
        {
            adresseTarget = ((Entry)sender).Text;
        }

        private void retour(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
    }
}
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
        public Page2()
        {
            InitializeComponent();
        }


        private void MailMDP(object sender, EventArgs e)
        {
            EmailMessage smsMessage = new EmailMessage
            {
                Subject = "test hackathon",
                Body = "voici le test pour le hackathon et ça marche",
                To = { "clement.montagna@viacesi.fr" }
            };
            var fn = "Attachment.txt";
            var fichier = Path.Combine(FileSystem.CacheDirectory, fn);
            
            smsMessage.Attachments.Add(new EmailAttachment(fichier));
            
            Task slt = Email.ComposeAsync(smsMessage);


        }
            

        private void OnEntryCompleted(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
        }
    }
}
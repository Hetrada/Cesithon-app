using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HalieuFish
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InscriptionPecheur : ContentPage
    {
        public InscriptionPecheur()
        {
            InitializeComponent();
            string 
        }
        private void creerUser(object sender, EventArgs e)
        {
            
        }

        private void precedent(object sender, EventArgs e)
        {
            App.Current.MainPage = new Page1();
        }

        public void OnEntryCompletedCE(object sender, EventArgs e)
        {
            codeE = ((Entry)sender).Text;

        }

        public void OnEntryCompletedAME(object sender, EventArgs e)
        {
            adresseME = ((Entry)sender).Text;
        }

        private void OnEntryCompletedMDP(object sender, EventArgs e)
        {
            mdp = ((Entry)sender).Text;
        }

        private void OnEntryCompletedNE(object sender, EventArgs e)
        {
            nomE = ((Entry)sender).Text;
        }
    }
}
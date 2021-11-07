using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HalieuFish
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InscriptionEntreprise : ContentPage
    {
        string codeE = null;
        string adresseME = null;
        string mdp = null;
        string nomE = null;
        public InscriptionEntreprise()
        {
            InitializeComponent();
            
        }

        private void precedent(object sender, EventArgs e)
        {
            App.Current.MainPage = new Page1();
        }

        private void CreerUserE(object sender, EventArgs e)
        {
            
            if (codeE == null || nomE == null || adresseME == null || mdp == null)
            {
                PopUP(2);
            }
            else
            {
                Console.WriteLine("if ok");
                UtilisateurE unUtilisateurE;
                unUtilisateurE = new UtilisateurE();
                unUtilisateurE.setValue(codeE, nomE, adresseME, mdp);
                Console.WriteLine("class ok");
                PopUP(1);
                App.Current.MainPage = new MainPage();
            }


        }

        public async void PopUP(int choixPop)
        {
            if (choixPop == 1)
            {
                await DisplayAlert("Félicitation", "Votre compte a bien été créer, vous avez été rediriger vers la page de connexion", "OK");
            }
            if (choixPop == 2)
            {
                await DisplayAlert("Attention", "Vous n'avez pas remplis tout les champs, veuillez tous les remplirs !", "OK");
            }          
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

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
        string nom;
        string prenom;
        string codeE;
        string immat;
        string mdpp;
        string adresseP;

        public InscriptionPecheur()
        {
            InitializeComponent();
            


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
            private void CreerUser(object sender, EventArgs e)
        {           

            if (nom == null || prenom == null || codeE == null || mdpp == null || immat == null)
            {
                PopUP(2);
            }
            else
            {
                UtilisateurP unUtilisateurP;
                unUtilisateurP = new UtilisateurP();
                unUtilisateurP.setvalue(nom, prenom, codeE, mdpp, immat, adresseP);
                PopUP(1);
                App.Current.MainPage = new MainPage();
            }
        }


        private void precedent(object sender, EventArgs e)
        {
            App.Current.MainPage = new Page1();
        }

        private void Enterprenom(object sender, EventArgs e)
        {
            prenom = ((Entry)sender).Text;
        }

        private void EntercodeE(object sender, EventArgs e)
        {
            codeE = ((Entry)sender).Text;
        }

        private void Entername(object sender, EventArgs e)
        {
            nom = ((Entry)sender).Text;
        }

        private void EnterImmat(object sender, EventArgs e)
        {
            immat = ((Entry)sender).Text;
        }

        private void EnterMail(object sender, EventArgs e)
        {
            adresseP = ((Entry)sender).Text;
        }

        private void EnterMdp(object sender, EventArgs e)
        {
            mdpp = ((Entry)sender).Text;
        }
    }
}
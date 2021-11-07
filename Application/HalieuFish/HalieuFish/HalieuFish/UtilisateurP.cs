using System;
using System.Collections.Generic;
using System.Text;

namespace HalieuFish
{
    public class UtilisateurP
    {
        public string nom;
        public string prenom;
        public string adresseP;
        public string codeE;
        public string mdp;
        public string immatriculation;

        public UtilisateurP()
        {

        }

        public void setvalue(string setNom, string setPrenom, string setCodeE, string setMdp, string setImmat, string setadresseP)
        {
            nom = setNom;
            prenom = setPrenom;

            codeE = setCodeE;
            mdp = setMdp;
            immatriculation = setImmat;
            adresseP = setadresseP;
        }

        public async void PopUpCon(int choix)
        {
            if (choix == 1)
            {
                await App.Current.MainPage.DisplayAlert("Attention", "Les identifiants sont incorectes", "OK");
            }
            if (choix == 2)
            {
                await App.Current.MainPage.DisplayAlert("Attention", "Fonctionnalité en cour de développement", "OK");
            }
        }
    }

    public class DonnesUP : UtilisateurP
    {
        public string mdpD;
        public DonnesUP() : base()
        {
            mdpD = mdp;
        }
        public void connexionP(string mdpEnter, string mailEnter)
        {
            Console.WriteLine(mdpEnter);
            Console.WriteLine(mailEnter);                     
            if (mdpEnter == "testP" && mailEnter == "baptistelerate@gmail.com")
            {
                Console.WriteLine("Succes");
                App.Current.MainPage = new formulaire();
            }
            if (mdpEnter != "testP" && mailEnter != "baptistelerate@gmail.com" || mdpEnter == "testP" && mailEnter != "baptistelerate@gmail.com" || mdpEnter != "testP" && mailEnter == "baptistelerate@gmail.com")
            {
                
                PopUpCon(1);
            }

        }
    }
}   

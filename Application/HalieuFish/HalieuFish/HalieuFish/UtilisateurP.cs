using System;
using System.Collections.Generic;
using System.Text;

namespace HalieuFish
{
    class UtilisateurP
    {
        public string nom;
        public string prenom;
        public DateTime dateN;
        public string adresseP;
        public string nomE;
        public string codeE;
        public string mdp;
        public string immatriculation;

        public UtilisateurP()
        {

        }

        public void setvalue(string setNom, string setPrenom, DateTime setDateN, string setAdresseP, string setNomE, string setCodeE, string setMdp, string setImmat)
        {
            nom = setNom;
            prenom = setPrenom;
            dateN = setDateN;
            adresseP = setAdresseP;
            codeE = setCodeE;
            mdp = setMdp;
            immatriculation = setImmat;
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
}   

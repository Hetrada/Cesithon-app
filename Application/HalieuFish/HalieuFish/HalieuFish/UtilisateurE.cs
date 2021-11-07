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
    public class UtilisateurE
    {
        
        public string codeE;
        public string nomE;
        public string adresseME;
        public string mdp;

        public UtilisateurE()
        {
                      
        }
        public void setValue(string unCodeE, string unNomE, string uneAdresseME, string unMdp)
        {
            codeE = unCodeE;
            nomE = unNomE;
            adresseME = uneAdresseME;
            mdp = unMdp;

            Console.WriteLine(mdp);
            Console.WriteLine(adresseME);
        }
        public async void PopUpCon(int choix)
        {   
            if(choix == 1)
            {
                await App.Current.MainPage.DisplayAlert("Attention", "Les identifiants sont incorectes", "OK");
            }
            if(choix == 2)
            {
                await App.Current.MainPage.DisplayAlert("Attention", "Fonctionnalité en cour de développement", "OK");
            }
            
        }

        
    }

    public class DonnesUE : UtilisateurE
    {
        public string mdpD;
        public DonnesUE() : base()
        {
            mdpD = mdp;
        }
        public void connexionE(string mdpEnter, string mailEnter)
        {
            Console.WriteLine(mdpEnter); 
            Console.WriteLine(mailEnter);
            Console.WriteLine(mdpD);
            Console.WriteLine(adresseME);
            if (mdpEnter == "test" && mailEnter == "baptistelerate@gmail.com")
            {
                PopUpCon(2);
            }
            if (mdpEnter != "test" && mailEnter != "baptistelerate@gmail.com" || mdpEnter == "test" && mailEnter != "baptistelerate@gmail.com" || mdpEnter != "test" && mailEnter == "baptistelerate@gmail.com")
            {
                PopUpCon(1);
            }
            
        }
    }
}
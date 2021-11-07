using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Xamarin.Forms;
using MySqlConnector;

namespace HalieuFish
{
    
    public partial class MainPage : ContentPage 
    {
        string mdpC = null;
        string mailC = null;

   

        public MainPage()
        {
            InitializeComponent();        

        }

        private void GoCreation(object sender, EventArgs e)
        {
            App.Current.MainPage = new Page1();
        }

        private void GoMdpOubliee(object sender, EventArgs e)
        {
            App.Current.MainPage = new Page2();
        }

       /* void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = new Entry();
            
        }/*

        /*void OnEntryCompleted(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
            if(text == "pecheur")
            {
                App.Current.MainPage = new formulaire();
            }
        }*/

        private void GoFormulaire(object sender, EventArgs e)
        {
            
        }

        public void GoConnexion(object sender, EventArgs e)
        {
            
            Console.WriteLine("C'est ce mdp"+mdpC);
            
            if (mdpC == "testE")
            {
                Console.WriteLine("!!!!!!!!!!! Entreprise");
                DonnesUE uneDonneE;
                uneDonneE = new DonnesUE();
                uneDonneE.connexionE(mdpC, mailC);
            }
            if (mdpC == "testP")
            {
                Console.WriteLine("!!!!!!!!!!! Pecheur");
                DonnesUP uneDonneP;
                uneDonneP = new DonnesUP();
                uneDonneP.connexionP(mdpC, mailC);
                
            }
            if(mdpC != "testE" && mdpC != "testP")
            {
                PopUpError();
            }

            
        }

        public async void PopUpError()
        {
            await DisplayAlert("Erreur", "Les idendifiant ne correspondent pas !", "OK");
        }
        public void OnEntryCompletedMAC(object sender, EventArgs e)
        {
            mailC = ((Entry)sender).Text;
        }

        public void OnEntryCompletedMDC(object sender, EventArgs e)
        {
            mdpC = ((Entry)sender).Text;
        }

        
    }
}

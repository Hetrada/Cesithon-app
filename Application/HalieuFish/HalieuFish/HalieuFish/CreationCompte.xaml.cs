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
    public partial class Page1 : ContentPage
    {
        public Page1()
            
        {
            InitializeComponent();

        }

        /*public void CreationEntreprise(object sender, CheckedChangedEventArgs e)
        {
            App.Current.MainPage = new Page2();
        }*/

       /* public void CreationPecheur(object sender, CheckedChangedEventArgs e)
        {
           
        }*/

        private void inscriptionEntreprise(object sender, EventArgs e)
        {
            App.Current.MainPage = new InscriptionEntreprise();
        }

        private void inscriptionPecheur(object sender, EventArgs e)
        {
            App.Current.MainPage = new InscriptionPecheur();
        }

        private void retour(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
    }
}
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
        }
        private void creerUser(object sender, EventArgs e)
        {
            
        }

        private void precedent(object sender, EventArgs e)
        {
            App.Current.MainPage = new Page1();
        }

        
    }
}
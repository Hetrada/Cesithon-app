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

        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = new Entry();
            
        }

        void OnEntryCompleted(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
            if(text == "pecheur")
            {
                App.Current.MainPage = new formulaire();
            }
        }

        
    }
}

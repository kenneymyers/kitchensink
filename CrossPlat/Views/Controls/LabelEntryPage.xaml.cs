using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CrossPlat.Views.Controls
{
    public partial class LabelEntryPage : ContentPage
    {
        public LabelEntryPage()
        {
            InitializeComponent();
        }

        public async void Login_Clicked(Object sender, EventArgs e){
            string user = username.Text;
            string pass = password.Text;
            await DisplayAlert("Login Details", "Username: " + user + " Password: " + pass, "OK");
        }
    }
}

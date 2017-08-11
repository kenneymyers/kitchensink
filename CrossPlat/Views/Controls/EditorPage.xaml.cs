using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CrossPlat.Views.Controls
{
    public partial class EditorPage : ContentPage
    {
        public EditorPage()
        {
            InitializeComponent();
        }

        protected void btnSubmitClicked(Object sender, EventArgs e){
            DisplayAlert("Description", edDescription.Text, "OK");
        }
    }
}

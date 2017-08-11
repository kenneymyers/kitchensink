using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CrossPlat.Views.Pages
{
    public partial class ContentPage2 : ContentPage
    {
        public ContentPage2 ()
        {
            InitializeComponent ();
        }

        public string LabelText {
            get{ return label.Text; }
            set{ label.Text = value; }
        }
    }
}

﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CrossPlat.Views.Pages
{
    public partial class PagesPage : ContentPage
    {
        public PagesPage()
        {
            InitializeComponent();
        }

        public void MasterDetail_Clicked(Object sender, EventArgs e)
        {
            //do something
            Navigation.PushAsync(new MasterDetail());
        }

        public void TabPage_Clicked(Object sender, EventArgs e)
        {
            //do something

            Navigation.PushAsync(new TabPage());
        }

        public void Carousel_Clicked(Object sender, EventArgs e)
        {
            //do something

            Navigation.PushAsync(new Carousel());
        }
    }
}

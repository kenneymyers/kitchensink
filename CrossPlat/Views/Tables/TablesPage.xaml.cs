﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CrossPlat.Views.Tables
{
    public partial class TablesPage : ContentPage
    {
        public TablesPage()
        {
            InitializeComponent();
        }

        public void TextCellPage_Clicked(Object sender, EventArgs e)
        {
            //do something

            Navigation.PushAsync(new TextCellPage());
        }

        public void ViewCellPage_Clicked(Object sender, EventArgs e)
        {
            //do something

            Navigation.PushAsync(new ViewCellPage());
        }

        public void ImageCellPage_Clicked(Object sender, EventArgs e)
        {
            //do something

            Navigation.PushAsync(new ImageCellPage());
        }

        public void EntryCellPage_Clicked(Object sender, EventArgs e)
        {
            //do something

            Navigation.PushAsync(new EntryCellPage());
        }
    }
}

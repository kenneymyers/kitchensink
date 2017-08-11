﻿using System;
using System.Collections.Generic;
using CrossPlat.Views.ComplexControls;
using CrossPlat.Views.Controls;
using CrossPlat.Views.Layouts;
using CrossPlat.Views.Pages;
using CrossPlat.Views.Tables;
using CrossPlat.Views;
using Xamarin.Forms;
using CrossPlat.Views.Other;

namespace CrossPlat
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        public void Layouts_Clicked(Object sender, EventArgs e){
            //do something
            //await DisplayAlert("Click", "Stack Layout", "OK");
            Navigation.PushAsync(new Layouts());

        }

		public void Controls_Clicked(Object sender, EventArgs e)
		{
			//do something
           Navigation.PushAsync(new ControlsPage());

		}

		public void ComplexControls_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new ComplexControlsPage());

		}

		public void Pages_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new PagesPage());

		}

		public void Tables_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new TablesPage());

		}

		public void Database_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new DatabasePage());

		}

		public void Json_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new JsonPage());

		}

		public void Other_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new OtherPage());

		}

    }
}

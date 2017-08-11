﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CrossPlat.Views.Layouts
{
    public partial class Layouts : ContentPage
    {
        public Layouts()
        {
            InitializeComponent();
        }

		public void StackLayout_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new StackLayoutPage());

		}

		public void AbsoluteLayout_Clicked(Object sender, EventArgs e)
		{
			//do something
            Navigation.PushAsync(new AbsoluteLayoutPage());
		}

		public void RelativeLayout_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new RelativeLayoutPage());
		}

		public void GridLayout_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new GridLayoutPage());
		}

		public void ContentView_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new ContentViewPage());
		}

		public void ScrollView_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new ScrollViewPage());
		}

		public void FrameView_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new FrameViewPage());
		}
    }
}

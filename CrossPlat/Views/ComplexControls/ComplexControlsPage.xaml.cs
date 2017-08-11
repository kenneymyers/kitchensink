using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CrossPlat.Views.ComplexControls
{
    public partial class ComplexControlsPage : ContentPage
    {
        public ComplexControlsPage()
        {
            InitializeComponent();
        }

		public void Activity_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new ActivityPage());
		}

		public void SearchPage_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new SearchPage());
		}

		public void PickerPage_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new PickerPage());
		}

		public void ListviewPage_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new ListviewPage());
		}

		public void ListViewOptionsPage_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new ListViewOptionsPage());
		}

		public void WebViewPage_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new WebViewPage());
		}

	}
}

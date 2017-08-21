using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CrossPlat.Views.Other
{
    public partial class OtherPage : ContentPage
    {
        public OtherPage()
        {
            InitializeComponent();
        }

		public void Behavior_Clicked(Object sender, EventArgs e)
		{
			//do something

			Navigation.PushAsync(new BehaviorPage());
		}

		public void Binding_Clicked(Object sender, EventArgs e)
		{
			//do something

			Navigation.PushAsync(new BindingPage());
		}

		public void Settings_Clicked(Object sender, EventArgs e)
		{
			//do something

			Navigation.PushAsync(new SettingsPage());
		}

		public void DevExpress_Clicked(Object sender, EventArgs e)
		{
			//do something

			Navigation.PushAsync(new DevExpressPage());
		}

    }
}

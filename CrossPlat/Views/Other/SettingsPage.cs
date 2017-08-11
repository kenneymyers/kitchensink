using System;

using Xamarin.Forms;

namespace CrossPlat.Views.Other
{
    public class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
			var editField = new Entry
			{
				Placeholder = "Enter text for setting",
				Text = CrossPlat.Helpers.Settings.GeneralSettings
			};
			var buttonSave = new Button
			{
				Text = "Save Setting"
			};

			var buttonGet = new Button
			{
				Text = "Get Setting"
			};
            // The root page of your application

            this.Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = "Enter value to save to settings:"
                        }, editField,
            buttonSave,
            buttonGet
                    }
            };

			buttonSave.Clicked += (sender, args) =>
			  {
				  CrossPlat.Helpers.Settings.GeneralSettings = editField.Text;
			  };

			buttonGet.Clicked += (sender, args) =>
			  {
				  this.DisplayAlert("Current Value:", CrossPlat.Helpers.Settings.GeneralSettings, "OK");
			  };

        }
    }
}


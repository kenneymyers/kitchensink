using System;

using Xamarin.Forms;

namespace CrossPlat.Views.Controls
{
    public class SwitchPage : ContentPage
    {
		private Label lblSwitchResult;

		public SwitchPage()
		{
			Label lblSwitch = new Label
			{
				Text = "Go ahead and flip the switch!",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				TextColor = Color.Black
			};

			lblSwitchResult = new Label
			{
				Text = "Switch toggled is: False",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				TextColor = Color.Black
			};

			Switch mySwitch = new Switch
			{
				IsToggled = false,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center
			};
			mySwitch.Toggled += (object sender, ToggledEventArgs e) =>
				lblSwitchResult.Text = "Switch toggled is: " + mySwitch.IsToggled.ToString();

			StackLayout stackLayout = new StackLayout
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = {
					lblSwitch,
					mySwitch,
					lblSwitchResult
				}
			};

			// Accomodate iPhone status bar.
			this.Padding = new Thickness(10, Device.OnPlatform(20, 10, 10), 10, 10);
			this.BackgroundColor = Color.White;

			// Build the page.
			this.Content = stackLayout;
		}
    }
}


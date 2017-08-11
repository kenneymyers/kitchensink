using System;

using Xamarin.Forms;

namespace CrossPlat.Views.Controls
{
    public class StepperPage : ContentPage
    {
		private Label lblValue;
		private Stepper stepper;

		public StepperPage()
		{
			StackLayout stackLayout = new StackLayout();
			stackLayout.VerticalOptions = LayoutOptions.FillAndExpand;

			stackLayout.Children.Add(new Label
			{
				Text = "Stepper Control",
				TextColor = Color.Black,
				Font = Font.SystemFontOfSize(NamedSize.Large),
				HorizontalOptions = LayoutOptions.Start
			});

			stepper = new Stepper(0, 25, 10, 0.1);
			stepper.HorizontalOptions = LayoutOptions.Center;
			stepper.VerticalOptions = LayoutOptions.Center;
			stepper.ValueChanged += stepperValueChanged;
			stackLayout.Children.Add(stepper);

			lblValue = new Label
			{
				Text = "Stepper Value = 10.0",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				TextColor = Color.Black
			};
			stackLayout.Children.Add(lblValue);

			// Accomodate iPhone status bar.
			this.Padding = new Thickness(10, Device.OnPlatform(20, 10, 10), 10, 10);
			this.BackgroundColor = Color.White;

			// Build the page.
			this.Content = stackLayout;
		}

		protected void stepperValueChanged(object sender, ValueChangedEventArgs e)
		{
			lblValue.Text = "Stepper Value = " + stepper.Value.ToString("F1");
		}
    }
}


using System;

using Xamarin.Forms;

namespace CrossPlat.Views.ComplexControls
{
    public class ActivityPage : ContentPage
    {
		private ActivityIndicator activityIndicator;
		private ProgressBar progressBar;
		private bool runProgress;

		public ActivityPage()
		{
			Label lblActivity = new Label
			{
				Text = "Activity Indicator",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				TextColor = Color.Black,
				VerticalOptions = LayoutOptions.Center
			};

			activityIndicator = new ActivityIndicator
			{
				Color = Device.OnPlatform(Color.Black, Color.Black, Color.Default),
				IsRunning = false,
				VerticalOptions = LayoutOptions.Center
			};

			Button btnActivityStart = new Button
			{
				Text = "Start Activity"
			};
			btnActivityStart.Clicked += (object sender, EventArgs e) => activityIndicator.IsRunning = true;

			Button btnActivityStop = new Button
			{
				Text = "Stop Activity"
			};
			btnActivityStop.Clicked += (object sender, EventArgs e) => activityIndicator.IsRunning = false;

			StackLayout activityStack = new StackLayout
			{
				Orientation = StackOrientation.Horizontal,
				Children = {
					btnActivityStart,
					btnActivityStop
				}
			};

			Label lblProgress = new Label
			{
				Text = "Progress Bar",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				TextColor = Color.Black,
				VerticalOptions = LayoutOptions.Center
			};

			progressBar = new ProgressBar
			{
				VerticalOptions = LayoutOptions.Center
			};

			Button btnProgressStart = new Button
			{
				Text = "Start Progress"
			};
			btnProgressStart.Clicked += (object sender, EventArgs e) =>
			{
				Device.StartTimer(TimeSpan.FromSeconds(0.1), TimerCallback);
				runProgress = true;
			};

			Button btnProgressStop = new Button
			{
				Text = "Stop Progress"
			};
			btnProgressStop.Clicked += (object sender, EventArgs e) => runProgress = false;

			StackLayout progressStack = new StackLayout
			{
				Orientation = StackOrientation.Horizontal,
				Children = {
					btnProgressStart,
					btnProgressStop
				}
			};

			StackLayout stackLayout = new StackLayout
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = {
					lblActivity,
					activityIndicator,
					activityStack,
					lblProgress,
					progressBar,
					progressStack
				}
			};

			// Accomodate iPhone status bar.
			this.Padding = new Thickness(10, Device.OnPlatform(20, 10, 10), 10, 10);
			this.BackgroundColor = Color.White;

			// Build the page.
			this.Content = stackLayout;
		}

		bool TimerCallback()
		{
			progressBar.Progress += 0.01;
			return runProgress && progressBar.Progress != 1;
		}
    }
}


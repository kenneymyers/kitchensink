using System;

using Xamarin.Forms;

namespace CrossPlat.Views.ComplexControls
{
    public class SearchPage : ContentPage
    {
		private Label lblSearchResult;

		public SearchPage()
		{
			Label lblSearch = new Label
			{
				Text = "Search Below",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				TextColor = Color.Black
			};

			lblSearchResult = new Label
			{
				Text = "Results:",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				TextColor = Color.Black
			};

            SearchBar searchBar = new SearchBar
            {
                Placeholder = "Enter a search string",
                BackgroundColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 400
                                                                            
			};

			searchBar.SearchButtonPressed += (object sender, EventArgs e) =>
				lblSearchResult.Text = "You searched for: " + searchBar.Text;

			StackLayout stackLayout = new StackLayout
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = {
					lblSearch,
					searchBar,
					lblSearchResult
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


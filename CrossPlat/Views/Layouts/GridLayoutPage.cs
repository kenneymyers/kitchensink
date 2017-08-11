using System;

using Xamarin.Forms;

namespace CrossPlat.Views.Layouts
{
    public class GridLayoutPage : ContentPage
    {
        public GridLayoutPage()
        {
            Grid grid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions = {
                    new RowDefinition{Height = GridLength.Auto},
                    new RowDefinition{Height = new GridLength(100,GridUnitType.Absolute)},
                    new RowDefinition{Height = new GridLength(75,GridUnitType.Absolute)},
                    new RowDefinition{Height = new GridLength(1,GridUnitType.Star)}
                },
                ColumnDefinitions = {
                    new ColumnDefinition{Width = GridLength.Auto},
                    new ColumnDefinition{Width = new GridLength(80, GridUnitType.Absolute)},
                    new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)},
                }

            };

            //Row 1
            grid.Children.Add(new Label
            {
                Text = "Header Label Spans 3 Columns.",
                Font = Font.BoldSystemFontOfSize(12),
                HorizontalOptions = LayoutOptions.Center
            }, 0, 3, 0, 1);

            //Row 2
			grid.Children.Add(new Label
			{
				Text = "Autosized",
				TextColor = Color.Black,
				BackgroundColor = Color.White
			}, 0, 1);

            grid.Children.Add(new Label
            {
                Text = "Height=100, Width=80",
                TextColor = Color.Black,
                BackgroundColor = Color.White
            }, 1, 1);

			grid.Children.Add(new Label
			{
				Text = "Height=100, Width=*",
				TextColor = Color.Black,
				BackgroundColor = Color.White
			}, 2, 1);

            //Row 3
            grid.Children.Add(new Label
            {
                Text = "Height=75, Width=Auto",
                TextColor = Color.White,
                BackgroundColor = Color.Navy
            }, 0, 2);

			grid.Children.Add(new Label
			{
				Text = "Span two rows",
				TextColor = Color.White,
				BackgroundColor = Color.Navy,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center
			}, 1, 2, 2, 4);

			grid.Children.Add(new Label
			{
				Text = "Height=75, Width=*",
				TextColor = Color.White,
				BackgroundColor = Color.Navy
			}, 2, 2);

			//Row 4
			grid.Children.Add(new Label
			{
				Text = "Height=*, Width=Auto",
				TextColor = Color.Black,
				BackgroundColor = Color.Silver
			}, 0, 3);

			grid.Children.Add(new Label
			{
				Text = "Height=*, Width=*",
				TextColor = Color.Black,
				BackgroundColor = Color.Silver
			}, 2, 3);

            //Accomodate iPhone status bar
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            this.Content = grid;
        }
    }
}


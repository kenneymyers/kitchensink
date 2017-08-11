using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CrossPlat.Views.ComplexControls
{
    public class ListviewPage : ContentPage
    {
        public ListviewPage ()
        {
            Label header = new Label
            {
                Text = "ListView",
                Font = Font.BoldSystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Center
            };

            List<string> listItems = new List<string>
            {
                "Main Page",
                "Photo Page",
                "Settings Page",
                "About Page"
            };

            ListView listView = new ListView
            {
                ItemsSource = listItems,
            };
            listView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) => {
                if (e.SelectedItem != null) {
                    DisplayAlert ("Item Selected", e.SelectedItem.ToString (), "OK");
                    listView.SelectedItem = null;
                }
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 10, 10), 10, 10);

            // Build the page.
            this.Content = new StackLayout {
                Children = {
                    header,
                    listView
                }
            };

        }
    }
}


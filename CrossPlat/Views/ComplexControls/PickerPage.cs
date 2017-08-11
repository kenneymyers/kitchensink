using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CrossPlat.Views.ComplexControls
{
    public class PickerPage : ContentPage
    {
        private Label lblPickerResult;
        private Dictionary<int, string> items = new Dictionary<int, string>
        {
            { 1, "Bob" },
            { 2, "Ted" },
            { 3, "Carol" },
            { 4, "Alice" }
        };

        public PickerPage ()
        {
            Label lblPicker = new Label {
                Text = "Pick a Name Below",
                Font = Font.SystemFontOfSize (NamedSize.Large),
                TextColor = Color.Black
            };

            lblPickerResult = new Label {
                Text = "You chose:",
                Font = Font.SystemFontOfSize (NamedSize.Large),
                TextColor = Color.Black
            };

            Picker picker = new Picker
            {
                Title = "Pick a Name",
                BackgroundColor = Color.Black,
                VerticalOptions = LayoutOptions.Center
            };
            foreach (string name in items.Values)
            {
                picker.Items.Add(name);
            }
            picker.SelectedIndexChanged += (object sender, EventArgs e) => 
                lblPickerResult.Text = "You chose: " + picker.Items[picker.SelectedIndex];

            StackLayout stackLayout = new StackLayout {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    lblPicker,
                    picker,
                    lblPickerResult
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


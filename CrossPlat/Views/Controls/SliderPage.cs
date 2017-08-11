using System;

using Xamarin.Forms;

namespace CrossPlat.Views.Controls
{
    public class SliderPage : ContentPage
    {
        private Label lblValue;
        private Slider slider;

        public SliderPage()
        {
            StackLayout stackLayout = new StackLayout();
            stackLayout.VerticalOptions = LayoutOptions.FillAndExpand;

            stackLayout.Children.Add(new Label
            {
                Text = "Slider Control",
                TextColor = Color.Black,
                Font = Font.SystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Start
            });

            slider = new Slider(0, 25, 10);
            slider.ValueChanged += sliderValueChanged;
            stackLayout.Children.Add(slider);

            lblValue = new Label
            {
                Text = "Slider Value = 10.0",
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

        protected void sliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblValue.Text = "Slider Value = " + slider.Value.ToString("F1");

        }
    }
}


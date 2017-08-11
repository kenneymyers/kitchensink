using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CrossPlat.Views.Controls
{
    public partial class ControlsPage : ContentPage
    {
        public ControlsPage()
        {
            InitializeComponent();
        }

		public void LabelEntry_Clicked(Object sender, EventArgs e)
		{
            //do something
			Navigation.PushAsync(new LabelEntryPage());
		}

		public void ImagePage_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new ImagePage());
		}

		public void EditorPage_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new EditorPage());
		}

		public void DateTimePage_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new DateTimePage());
		}

		public void SliderPage_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new SliderPage());
		}

		public void StepperPage_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new StepperPage());
		}

		public void SwitchPage_Clicked(Object sender, EventArgs e)
		{
			//do something
			Navigation.PushAsync(new SwitchPage());
		}

    }
}

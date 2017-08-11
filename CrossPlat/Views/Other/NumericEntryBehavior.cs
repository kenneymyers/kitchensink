using System;
using Xamarin.Forms;

namespace CrossPlat.Views.Other
{
    public class NumericEntryBehavior : Behavior<Entry>
    {
		//Attach to the Entry event we need
		protected override void OnAttachedTo(Entry bindable)
		{
			base.OnAttachedTo(bindable);
			bindable.TextChanged += TextChanged_Handler;
		}

		void TextChanged_Handler(object sender, TextChangedEventArgs e)
		{
			double num;
			if (string.IsNullOrEmpty(e.NewTextValue))
			{
				return;
			}
			if (!double.TryParse(e.NewTextValue, out num))
			{
				((Entry)sender).Text = e.OldTextValue;
			}
		}

		//Detach from the event to avoid memory leaks
		protected override void OnDetachingFrom(Entry bindable)
		{
			base.OnAttachedTo(bindable);
			bindable.TextChanged -= TextChanged_Handler;
		}
    }
}

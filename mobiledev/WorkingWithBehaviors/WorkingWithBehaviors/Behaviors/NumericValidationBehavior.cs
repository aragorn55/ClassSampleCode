using System;
using Xamarin.Forms;
using System.Diagnostics.Contracts;


namespace WorkingWithBehaviors
{
	public class NumericValidationBehavior: Behavior<Entry>
	{
		protected override void OnAttachedTo(Entry entry)
		{
			entry.TextChanged += OnEntryTextChanged;
			base.OnAttachedTo (entry);
		}
		protected override void OnDetachingFrom(Entry entry)
		{
			entry.TextChanged -= OnEntryTextChanged;
			base.OnDetachingFrom (entry);
		}


		void OnEntryTextChanged (object sender, TextChangedEventArgs e)
		{
			double result;
			bool isValid = Double.TryParse (e.NewTextValue, out result);
			// Intermediate if
			((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;
		}
	}
}


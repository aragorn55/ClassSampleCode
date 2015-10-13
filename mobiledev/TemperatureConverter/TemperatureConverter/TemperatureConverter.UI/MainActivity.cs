using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using TemperatureConverter.BL;

namespace TemperatureConverter.UI
{
	[Activity (Label = "Temperature Converter")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button btnConvert = FindViewById<Button> (Resource.Id.btnConvert);
			EditText txtInput = FindViewById<EditText> (Resource.Id.txtInput);
			RadioButton rbtnC = FindViewById<RadioButton> (Resource.Id.rbtnC);
			RadioButton rbtnF = FindViewById<RadioButton> (Resource.Id.rbtnF);
			ToggleButton btnToggle = FindViewById<ToggleButton> (Resource.Id.toggleButton1);
			Switch s = FindViewById<Switch> (Resource.Id.switch1);
				
			// Set up an event for the switch toggle.
			s.CheckedChange+= delegate(object sender, CompoundButton.CheckedChangeEventArgs e) {
				var toast = Toast.MakeText(this, " You picked " + (e.IsChecked ? "Celsius" : "Fahrenheit"), ToastLength.Short);
				toast.Show();
			};

			btnConvert.Click += delegate {
				if (s.Checked)			
					txtInput.Text = CTempConvert.ToCelsius(double.Parse(txtInput.Text)).ToString();
				else
					txtInput.Text = CTempConvert.ToFahrenheit(double.Parse(txtInput.Text)).ToString();
			};

			/*
			btnConvert.Click += delegate {
				if (rbtnC.Checked)			
					txtInput.Text = CTempConvert.ToCelsius(double.Parse(txtInput.Text)).ToString();
				else
					txtInput.Text = CTempConvert.ToFahrenheit(double.Parse(txtInput.Text)).ToString();
			};
			
			btnConvert.Click += delegate {
				if (btnToggle.Checked)			
					txtInput.Text = CTempConvert.ToCelsius(double.Parse(txtInput.Text)).ToString();
				else
					txtInput.Text = CTempConvert.ToFahrenheit(double.Parse(txtInput.Text)).ToString();
			};
			*/
		}
	}
}



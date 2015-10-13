using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using TempConverterPro.PCL;
namespace TempConverterPro.Droid
{
	[Activity (Label = "TempConverterPro.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;
		double dblTemp = 0.0;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			Button btnConvert = FindViewById<Button> (Resource.Id.btnConvert);
			EditText txtInput = FindViewById<EditText> (Resource.Id.txtInput);
			RadioButton rbtnToF = FindViewById<RadioButton> (Resource.Id.rbtnToF);
			RadioButton rbtnToC = FindViewById<RadioButton> (Resource.Id.rbtnToC);
			ToggleButton btnToggle = FindViewById<ToggleButton> (Resource.Id.btnToggle);
		//	Switch s = FindViewById<Switch> (Resource.Id.switch1);
		//	s.CheckedChange+= delegate(object sender, CompoundButton.CheckedChangeEventArgs e) {
		//		var toast = Toast.MakeText(this, " You picked " + (e.IsChecked ? "Celsius" : "Fahrenheit"), ToastLength.Long);
		//		toast.Show();
	//		};
			btnConvert.Click += delegate {
				TempConverter.TempConvert client = new TempConverter.TempConvert();
			//	if(s.Checked)

			//	{
					txtInput.Text = client.FahrenheitToCelsius (txtInput.Text);
//					string sInput = txtInput.Text;
//
//					bool valid = double.TryParse(sInput, out dblTemp);
//
//					double dblConvert = CTempConvert.ConvertToCelsius(dblTemp);
//					txtInput.Text = dblTemp.ToString();
		//		}
//				else
//				{
////					string sInput = txtInput.Text;
//					txtInput.Text = client.CelsiusToFahrenheit (txtInput.Text);
////
////					bool valid = double.TryParse(sInput, out dblTemp);
////
////					double dblConvert = CTempConvert.ConvertToFahrenheit(dblTemp);
////					txtInput.Text = dblTemp.ToString();
//
//				}
			
				
			};
			btnToggle.Click += delegate {
				
			};

			// Get our button from the layout resource,
			// and attach an event to it

			
		
		}
	}
}



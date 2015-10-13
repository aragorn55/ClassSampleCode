
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TempConverterPro.Droid
{

	[Activity (Label = "SpinnerActivity")]			
	public class SpinnerActivity : Activity
	{
		string[] cities = { "Bosie", "Appleton", "Milwaukee" };
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main2);
			// Create your application here
			//get and bind the spinner to the resources string array
			Spinner spinner = FindViewById<Spinner> (Resource.Id.spinner);

			spinner.ItemSelected += Spinner_ItemSelected;
			//var adapter = ArrayAdapter.CreateFromResource (this,Resource.Array.city_array, Android.Resource.Layout.SimpleSpinnerItem);
			//get array from external resources
			var adapter = new ArrayAdapter (this, Android.Resource.Layout.SimpleSpinnerItem, cities);

			adapter.SetDropDownViewResource (Android.Resource.Layout.SimpleSpinnerDropDownItem);

		}

		void Spinner_ItemSelected (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			Spinner spinner = (Spinner)sender;
			string toast = string.Format ("This city is {0}", spinner.GetItemAtPosition (e.Position));
			Toast.MakeText (this, e.Position, ToastLength.Long).Show ();
		}
	}
}



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

namespace TemperatureConverter.UI
{
	[Activity (Label = "SpinnerActivity")]			
	public class SpinnerActivity : Activity
	{
		string[] cities = { "Boise", "San Francisco", "Seattle", "San Juan" };

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main2" layout resource
			SetContentView (Resource.Layout.Main2);

			// GEt and bind the spinner to the resources string array
			Spinner spinner = FindViewById<Spinner> (Resource.Id.spinner);

			spinner.ItemSelected += Spinner_ItemSelected;

			// Get the array from resources
			//var adapter = ArrayAdapter.CreateFromResource (this, Resource.Array.city_array, Android.Resource.Layout.SimpleSpinnerItem);

			// Get the array from external data source
			var adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, cities);

			adapter.SetDropDownViewResource (Android.Resource.Layout.SimpleSpinnerDropDownItem);
			spinner.Adapter = adapter;
		}

		void Spinner_ItemSelected (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			Spinner spinner = (Spinner)sender;
			string toast = string.Format ("The city is {0}", spinner.GetItemAtPosition (e.Position));
			Toast.MakeText (this, toast, ToastLength.Long).Show ();
		}
	}
}


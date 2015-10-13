
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
using Android.Database;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace TempConverterPro.Droid
{
	[Activity (Label = "DateTimePickerActivity", MainLauncher = true, Icon = "@drawable/icon")]		
	public class DateTimePickerActivity : Activity
	{
		private TextView tvOutput;
		private Button btnPickDate;
		private DateTime date;
		private  int hour;
		private int minute;
		const int DATE_DIALOG_ID = 0;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.DateTimePicker);
			// Create your application here
			btnPickDate =  FindViewById<Button> (Resource.Id.btnPickDate);
			tvOutput = FindViewById<TextView> (Resource.Id.tvOutput);
			btnPickDate.Click += (sender, e) => ShowDialog (DATE_DIALOG_ID);
		//	btnPickDate.Click += delegate() {
		//		UpdateDisplay();
		//	};
		}
		private void UpdateDisplay()
		{
			string sTime = string.Format ("{0}:{1}", hour, minute.ToString().PadLeft (2, '0'));
				tvOutput.Text = sTime;
		}
		void OnTimeSet(object sender, TimePickerDialog.TimeSetEventArgs e)
		{
			hour = e.HourOfDay;
			minute = e.Minute;
			UpdateDisplay ();

		}
		void OnDateSet(object sender, DatePickerDialog.DateSetEventArgs e)
		{
			this.date = e.Date;
			UpdateDisplay ();
		}
		/*
		protected override Dialog OnCreateDialog(int id)
		{

			switch(id)
			{
			case DATE_DIALOG_ID:
				return new DatePickerDialog (this, OnDateSet, date.Year, date.Month - 1, date.Day);
			}

		
		}
*/
	}
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimerPro.Core;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Timers;
namespace TimerPro.Android
{

	[Activity (Label = "MainTimer", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainTimer : Activity
	{
		CCustomerTimer  oCustomTimer = new CCustomerTimer();
		Timer oTimer = new Timer (1000);
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.uiTimer);
			Button btnStart = FindViewById<Button> (Resource.Id.btnStart);
			Button btnReset = FindViewById<Button> (Resource.Id.btnReset);
			Button btnStop = FindViewById<Button> (Resource.Id.btnStop);
			TextView tvDisplay = FindViewById<TextView> (Resource.Id.tvDisplay);
			// Create your application here
			btnStart.Enabled = true;
				btnStop.Enabled = false;
			btnStart.Click += delegate {
				btnStart.Enabled = false;
				btnStop.Enabled = true;
				oTimer.Start();
			};
			btnStop.Click += delegate {
				btnStart.Enabled = true;
				btnStop.Enabled = false;
				oTimer.Stop();
			};
			btnReset.Click += delegate {
				btnStart.Enabled = false;
				btnStop.Enabled = true;
				oCustomTimer.Reset();

				oTimer.Start();
			};
			oTimer.Elapsed += delegate(object sender, ElapsedEventArgs e) {
				oCustomTimer.SetTickElapsed();
				RunOnUiThread (delegate {
					tvDisplay.Text = oCustomTimer.GetCurrentTickCount();
				});
			};
		}
	}
}


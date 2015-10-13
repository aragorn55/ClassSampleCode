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
using DeathClock.PCL;

namespace DeathClock2.Droid
{
	[Activity (Label = "Results")]			
	public class Results : Activity
	{
		//cPerson _User;
		cDeathCalculator oCalc;
		public cPerson _User = new cPerson ();

		public Results ()
		{
			//_User = ((ControllClass)Application)._oUser;
			oCalc = new cDeathCalculator ();

		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Results);
			var UserData = Intent.Extras.GetStringArrayList ("Data") ?? new string[0];
			//CPersonPassable oPass = (CPersonPassable)Intent.GetParcelableExtra ("lifstyle");
			//_User = oPass.User;
			double _data = 0.0;

			double.TryParse (UserData [0], out _data);
			_User.Height = _data;
			double.TryParse (UserData [1], out _data);
			_User.Weight = _data;
			//double.TryParse (UserData[2], out _data);
			_User.SetBirthDay (UserData [2]);
			//double.TryParse (UserData[3], out _data);
			_User.SetGender (UserData [3]);
			double.TryParse (UserData [4], out _data);
			_User.HrsSleep = _data;
			double.TryParse (UserData [5], out _data);
			_User.CigPerDay = _data;

			var years = oCalc.FindTimeLeft (_User);
			TextView lblYears = FindViewById<TextView> (Resource.Id.lblYears);
			ImageView imgLogo = FindViewById<ImageView> (Resource.Id.imgLogo);
			imgLogo.SetImageResource (Resource.Drawable.clock);
			lblYears.Text = years.ToString ();
			//lblYears.Text = oCalc.FindTimeLeft (_User).ToString ();
			//	imgLogo.SetImageResource (Resource.Drawable.);//.Image = UIImage.FromBundle ("Images/clock.png");
			// Create your application here
		}
	}
}


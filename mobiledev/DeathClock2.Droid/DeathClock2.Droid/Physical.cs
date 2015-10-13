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
	[Activity (Label = "Physical", MainLauncher = true)]		
	public class Physical : Activity
	{
		DateTime _UserBday;
		cPerson _User;
		TextView lblDateDisplay;

		public Physical ()
		{
			
		}

		void SetDisplayDate ()
		{
			lblDateDisplay.Text = _UserBday.ToString ("d");
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Physical);
			_User = new cPerson ();
		
			_UserBday = DateTime.Today;
			EditText txtFeet = FindViewById<EditText> (Resource.Id.txtFeet);
			lblDateDisplay = FindViewById<TextView> (Resource.Id.lblDateDisplay);
			EditText txtInches = FindViewById<EditText> (Resource.Id.txtInches);
			EditText txtLbs = FindViewById<EditText> (Resource.Id.txtLbs);
			Button btnLifeStyle = FindViewById<Button> (Resource.Id.btnLifeStyle);
			Button btnChooseDate = FindViewById<Button> (Resource.Id.btnChooseDate);
			Switch swbtnGender = FindViewById<Switch> (Resource.Id.swbtnGender);
//			TextView lblinput = FindViewById<TextView> (Resource.Id.lblinput);
//			Button btngo = FindViewById<Button> (Resource.Id.btngo);


			btnChooseDate.Click += delegate {
				DatePickerDialog setDate = new DatePickerDialog (this, onDateSet, _UserBday.Year, _UserBday.Month - 1, _UserBday.Day);
				setDate.Show ();
				SetDisplayDate ();

			};

			SetDisplayDate ();
			btnLifeStyle.Click += delegate {
				double dFeet = -1;
				double dInches = -1;
				double dLbs = -1;
				if (double.TryParse (txtFeet.Text, out dFeet)) {
					if (double.TryParse (txtInches.Text, out dInches)) {
						_User.Height = (dFeet * 12.0) + dInches;
						if (double.TryParse (txtLbs.Text, out dLbs)) {
							_User.Weight = dLbs;
							if (swbtnGender.Checked) {
								_User.Sex = eGender.female;
							} else {
								_User.Sex = eGender.male;

							}
							_User.BirthDate = _UserBday;
							//	lblinput.Text = _User.Height.ToString () + " " + _User.Weight.ToString () + " " + _User.BirthDate.ToString () + " " + _User.Sex.ToString ();
							List<String> Data = new List<string> ();
							Data.Add (_User.Height.ToString ());
							Data.Add (_User.Weight.ToString ());
							Data.Add (_User.BirthDate.ToString ());
							Data.Add (_User.Sex.ToString ());
							var intent = new Intent (this, typeof(LifeStyle));
							intent.PutStringArrayListExtra ("Data", Data);
							StartActivity (intent);
							//	var _UserP = new CPersonPassable ();
							//_UserP.User = _User;
							//Intent.PutExtra ("_User", _User);
							//	var lifestyle = new Intent (this, typeof(LifeStyle));
							//	lifestyle.PutExtra ("ParceableObject", _UserP);
							//		StartActivity (lifestyle);
							//		intent.
							//intent.
							//intent.PutStringArrayListExtra ("phone_numbers", phoneNumbers);
							//StartActivity (intent);
						}
					}
				}
			

				//((ControllClass)Application)._oUser = _User;
				//StartActivity (typeof(LifeStyle));
			};
//			btngo.Click += delegate {
//				List<String> Data = new List<string> ();
//				Data.Add (_User.Height.ToString ());
//				Data.Add (_User.Weight.ToString ());
//				Data.Add (_User.BirthDate.ToString ());
//				Data.Add (_User.Sex.ToString ());
//				var intent = new Intent (this, typeof(LifeStyle));
//				intent.PutStringArrayListExtra ("Data", Data);
//				StartActivity (intent);
//			};

		}

		public void onDateSet (object sender, DatePickerDialog.DateSetEventArgs e)
		{
			_UserBday = e.Date;
			SetDisplayDate ();
		}

		
				
		
	}
}


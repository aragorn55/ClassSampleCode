
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
	public class UIPhysicalActivity : Activity
	{
		private DateTime _UserBday;
		//cPerson _User;
		private TextView lblDateDisplay;

		void SetDisplayDate ()
		{
			lblDateDisplay.Text = _UserBday.ToString ("d");
		}

		void onDateSet (object sender, DatePickerDialog.DateSetEventArgs e)
		{
			_UserBday = e.Date;
			SetDisplayDate ();
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.Physical);
			EditText txtFeet = FindViewById<EditText> (Resource.Id.txtFeet);
			lblDateDisplay = FindViewById<TextView> (Resource.Id.lblDateDisplay);
			EditText txtInches = FindViewById<EditText> (Resource.Id.txtInches);
			EditText txtLbs = FindViewById<EditText> (Resource.Id.txtLbs);
			Button btnLifeStyle = FindViewById<Button> (Resource.Id.btnLifeStyle);
			Button btnChooseDate = FindViewById<Button> (Resource.Id.btnChooseDate);
			RadioButton rbMale = FindViewById<RadioButton> (Resource.Id.rbMale);
			RadioButton rbFemale = FindViewById<RadioButton> (Resource.Id.rbFemale);
			RadioGroup rbGender = FindViewById<RadioGroup> (Resource.Id.rbGender);


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
						if (double.TryParse (txtLbs.Text, out dLbs)) {

							//openlifestyleView
							//							_User.BirthDate = _UserBday;
							//							_User.Height = (12.0 * dFeet) + dInches;
							//							_User.Weight = dLbs;
							((ControllClass)Application)._oUser.BirthDate = _UserBday;
							((ControllClass)Application)._oUser.Height = (12.0 * dFeet) + dInches;
							((ControllClass)Application)._oUser.Weight = dLbs;
							rbGender.CheckedChange += delegate {
								if (rbMale.Checked) {
									((ControllClass)Application)._oUser.Sex = eGender.male;
									//_User.Sex = eGender.male;
								} else if (rbFemale.Checked) {
									((ControllClass)Application)._oUser.Sex = eGender.female;
									//	_User.Sex = eGender.female;
								}
								//((ControllClass)Application)._oUser = _User;
								StartActivity (typeof(LifeStyle));
							};


						}
					}
				}

				//				if ((dFeet == -1)||(dInches == -1)||(dLbs == -1))
				//				{
				//									}

			};
		}
	}
}


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
using System.Runtime.Remoting.Messaging;


namespace DeathClock2.Droid
{
	[Activity (Label = "LifeStyle")]	
	public class LifeStyle : Activity
	{
		public cPerson _User = new cPerson ();
		//		public LifeStyle()
		//		{
		//			//_User = ((ControllClass)Application)._oUser;
		//
		//		}
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.LifeStyle);
			var UserData = Intent.Extras.GetStringArrayList ("Data") ?? new string[0];
			//	CPersonPassable oPass = (CPersonPassable)Intent.GetParcelableExtra ("ParceableObject");
			//	_User = oPass.User;
			//Button btnCalculate = FindViewById<Button> (Resource.Id.);
			EditText txtSleep = FindViewById<EditText> (Resource.Id.txtSleep);
			EditText txtCigarettes = FindViewById<EditText> (Resource.Id.txtCigarettes);
			Button btnCalculate = FindViewById<Button> (Resource.Id.btnCalculate);
			ImageView imgLifeStyle = FindViewById<ImageView> (Resource.Id.imgLifeStyle); 
			//TextView lblinput = FindViewById<TextView> (Resource.Id.lblinput);
			//Button btngo = FindViewById<Button> (Resource.Id.btngo);
			imgLifeStyle.SetImageResource (Resource.Drawable.life);
			//			imgLogo.Image = UIImage.FromBundle ("Images/clock.png");
			btnCalculate.Click += delegate(object sender, EventArgs e) {
				double dSleep = -1;
				double dCigarettes = -1;
				if (double.TryParse (txtSleep.Text, out dSleep)) {
					if (double.TryParse (txtCigarettes.Text, out dCigarettes)) {
						//((ControllClass)Application)._oUser.HrsSleep = dSleep;
						//((ControllClass)Application)._oUser.CigPerDay = dCigarettes;
						_User.HrsSleep = dSleep;
						_User.CigPerDay = dCigarettes;
						//_User.HrsSleep = dSleep;
						//_User.CigPerDay = dCigarettes;
						//((ControllClass)Application)._oUser = _User;
						//var _UserP = new CPersonPassable ();
						//	lblinput.Text = _User.HrsSleep.ToString () + " " + _User.CigPerDay.ToString ();
						//	var userData = UserData;
						UserData.Add (_User.HrsSleep.ToString ());
						UserData.Add (_User.CigPerDay.ToString ());

						var intent = new Intent (this, typeof(Results));
						intent.PutStringArrayListExtra ("Data", UserData);
						StartActivity (intent);
						//_UserP.User = _User;
						//UserData.Add (_User.HrsSleep.ToString ());
						//UserData.Add (_User.CigPerDay.ToString ());
						//Intent.PutExtra ("_User", _User);
						//	var intent = new Intent (this, typeof(Results));
						//	intent.PutStringArrayListExtra ("Data", UserData);
						//StartActivity (intent);
						//var result = new Intent (this, typeof(Results));
						//	result.PutExtra ("lifstyle", _UserP);
						//	StartActivity (result);
						//NavigationController.PushViewController(_cResultsVC,true);
					}
				}
//				if ((dSleep == -1)||(dCigarettes == -1))
//				{
//					//	UIAlertView alert = new  UIAlertView("Error", "Please input a number into all fields", "OK", null);
//					//	alert.Show(); 
//				}
			
			};
		
			//txtSleep.ShouldReturn = delegate {
			//	txtSleep.ResignFirstResponder();
			//	return true;
			//	};
//		txtCigarettes.ShouldReturn = delegate {
//			txtCigarettes.ResignFirstResponder();
//			return true;
//		};
		
		}

				

			




	}

}



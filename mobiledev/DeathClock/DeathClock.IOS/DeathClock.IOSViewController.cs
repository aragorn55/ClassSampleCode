using System;
using System.Drawing;
using Foundation;
using UIKit;
using DeathClock.PCL;
using System.CodeDom.Compiler;

namespace DeathClock.IOS
{
	public partial class DeathClock_IOSViewController : UIViewController
	{
		public cPerson _User;

		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public DeathClock_IOSViewController (IntPtr handle) : base (handle)
		{
			_User = new cPerson ();
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			txtFeet.Text = "6";
			txtInches.Text = "0";
			txtWeight.Text = "150";


			pickBDay.MaximumDate = NSDate.Now;
			pickBDay.ValueChanged += delegate {
				UIAlertView MessageBox = new UIAlertView ("Date", TimeConversion.NSDateToDateTime (pickBDay.Date).ToLocalTime ().ToString (), null, "Ok");
				MessageBox.Show ();
			};
			txtFeet.ShouldReturn = delegate {
				txtFeet.ResignFirstResponder ();
				return true;
			};
			txtInches.ShouldReturn = delegate {
				txtInches.ResignFirstResponder ();
				return true;
			};
			txtWeight.ShouldReturn = delegate {
				txtWeight.ResignFirstResponder ();
				return true;
			};
			// Perform any additional setup after loading the view, typically from a nib.
			btnCalculate.TouchUpInside += delegate {


				double dFeet;
				double dInches;
				double dLbs;


				if (double.TryParse (txtFeet.Text, out dFeet)) {

					if (double.TryParse (txtInches.Text, out dInches)) {

						if (double.TryParse (txtWeight.Text, out dLbs)) {

							//openlifestyleView

							_User.BirthDate = TimeConversion.NSDateToDateTime (pickBDay.Date);
							_User.Height = (12.0 * dFeet) + dInches;
							_User.Weight = dLbs;
							if (segGender.SelectedSegment == 0) {
								_User.Sex = eGender.male;
							} else {
								_User.Sex = eGender.female;
							}
							//ResultsViewController _ResultVC = new ResultsViewController (this);
							//_ResultVC.User = _User;

							//NavigationController.PushViewController (_ResultVC, true);
							// Launches a new instance of CallHistoryController
							ResultsViewController _ResultVC = this.Storyboard.InstantiateViewController ("ResultsVC") as ResultsViewController;
							if (_ResultVC != null) {
								_ResultVC.User = _User;
								_ResultVC.CalculateDeath ();
								this.NavigationController.PushViewController (_ResultVC, true);
							}

						}
					}
				}
			};
			// Perform any additional setup after loading the view, typically from a nib.
		}


		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}




		partial void btnCalculate_TouchUpInside (UIButton sender)
		{
			throw new NotImplementedException ();
		}


		partial void pickBDay_ValueChanged (UIDatePicker sender)
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}


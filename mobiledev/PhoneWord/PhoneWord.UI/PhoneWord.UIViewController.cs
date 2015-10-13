using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace PhoneWord.UI
{
	public partial class PhoneWord_UIViewController : UIViewController
	{
		string translatedNumber = "";

		public PhoneWord_UIViewController (IntPtr handle) : base (handle)
		{
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
			
			// Perform any additional setup after loading the view, typically from a nib.
			BtnConvert.TouchUpInside += (object sender, EventArgs e) => {
				translatedNumber = PhoneWord.UI.PhonewordTranslator.ToNumber (txtInputPhone.Text);

				//get rid of keyboard
				txtInputPhone.ResignFirstResponder ();
				if (translatedNumber == string.Empty) {
					btnCall.SetTitle ("Call ", UIControlState.Normal);

				} else
					lblOutput.Text = translatedNumber.ToString();
					btnCall.SetTitle ("Call " + translatedNumber, UIControlState.Normal);

			};
			btnCall.TouchUpInside += (object sender, EventArgs e) => 
			{
				var url = new NSUrl("tel:" + translatedNumber);
				if (!UIApplication.SharedApplication.OpenUrl(url))
				{
					var av = new UIAlertView("not supported",
						"Not supported on this device",
						null,
						"ok",
						null);
					av.Show();
				}



			};
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

		#endregion
	}
}


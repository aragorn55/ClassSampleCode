using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace MyFirstApp.UI
{
	public partial class MyFirstApp_UIViewController : UIViewController
	{
		int iCounter = 0;
		public MyFirstApp_UIViewController (IntPtr handle) : base (handle)
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


		partial void btnClick_TouchUpInside (UIButton sender)
		{
			//Display the time
			lblStatus.Text = DateTime.Now.ToString();
			new UIAlertView("MyFirstApp", "My First Message", null, "Cancel", null);

		}

		partial void btnDouble_TouchUpInside (UIButton sender)
		{
			//throw new NotImplementedException ();
			if (iCounter > 1 || iCounter != 0){

				lblClicks.Text = (iCounter++).ToString() + " clicks";
				iCounter += 1;
			}
			else{

					lblClicks.Text = iCounter.ToString() + " clicks";
				iCounter += 1;
			}

		}
		#endregion
	}
}
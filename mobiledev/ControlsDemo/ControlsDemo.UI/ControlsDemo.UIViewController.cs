using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace ControlsDemo.UI
{
	public partial class ControlsDemo_UIViewController : UIViewController
	{
		UILabel label1;
		UILabel label2;
		UILabel label3;
		UITextField txtTextField1;
		UIImageView imageView1;
		UITextView tvTextView1;
		UIButton btnDemo;

		public ControlsDemo_UIViewController (IntPtr handle) : base (handle)
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
			//create label programmaticaly
			var frame = new RectangleF (20, 20, 150, 25);
			label1 = new UILabel (frame);
			label1.BackgroundColor = UIColor.Cyan;
			label1.TextColor = UIColor.White;
			label1.TextAlignment = UITextAlignment.Center;
			label1.Text = "New label";

			//add the label and frame to the view
			View.Add (label1);
			frame = new RectangleF (55, 50, 100, 100);
			imageView1 = new UIImageView (frame);

			imageView1.Image = UIImage.FromBundle ("images/tux-baby.jpg");
			View.Add (imageView1);
			/*
			frame = new RectangleF (225, 50, 25, 25);

			View.AddSubview (imageView1);
			label3 = new UILabel (frame);
			label3.Text = "/dev/po";
			View.Add (label3);

*/
			txtTextField1 = new UITextField (frame);
			txtTextField1.Placeholder = "type email here...";
			txtTextField1.KeyboardType = UIKeyboardType.Twitter;
			txtTextField1.MinimumFontSize = 17f;
			txtTextField1.AdjustsFontSizeToFitWidth = true;
			View.Add (txtTextField1);
			frame = new RectangleF (160, 50, 150, 100);
			tvTextView1 = new UITextView (frame);
			tvTextView1.BackgroundColor = UIColor.Purple;
			tvTextView1.Editable = true;
			tvTextView1.DataDetectorTypes = UIDataDetectorType.PhoneNumber | UIDataDetectorType.Link;
			tvTextView1.TextColor = UIColor.White;
			txtTextField1.Text = "Linux is an open-source source OS http://www.linux.com";
			View.Add (tvTextView1);

			frame = new RectangleF (260, 50, 200, 25);
			btnDemo = new UIButton (frame);
			btnDemo.SetTitle ("Normal", UIControlState.Normal);
			btnDemo.SetTitleColor (UIColor.Black, UIControlState.Normal);
			btnDemo.SetTitle ("Disabled", UIControlState.Disabled);
			btnDemo.SetTitleColor (UIColor.Gray, UIControlState.Disabled);
			btnDemo.SetImage (UIImage.FromBundle ("image/MagicWand.png"), UIControlState.Normal);
			btnDemo.SetImage (UIImage.FromBundle ("image/MagicWand_Highlight.png"), UIControlState.Highlighted);
			btnDemo.SetImage (UIImage.FromBundle ("image/MagicWand_On.png"), UIControlState.Selected);

			btnDemo.TouchUpInside += (object sender, EventArgs e) => {
				label1.Text = "Button Click";

				var alert = new UIAlertView ("Alert Title",
					            "choose from two buttons",
					            null,
					            "OK",
					            new string[]{ "Cancel" });
				alert.Clicked += (object s, UIButtonEventArgs b) => {
					label1.Text = "Button " + b.ButtonIndex.ToString () + " clicked.";
					Console.WriteLine ("Button " + b.ButtonIndex.ToString () + " clicked.");
				};
				alert.Show ();

			};

			View.Add (btnDemo);

			View.BackgroundColor = UIColor.FromRGB (101, 156, 239);
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


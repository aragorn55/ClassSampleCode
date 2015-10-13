using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace TempConverter
{
	public partial class TempConverterViewController : UIViewController
	{
		private bool blnCovertToCelsius = true;
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public TempConverterViewController (IntPtr handle) : base (handle)
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


		private void ConvertToFahrenheit()
		{
			double dblTemp = 0.0;

			string sTemp = txtTemp.Text;

			if(double.TryParse(sTemp, out dblTemp))
			{
				double dblFahrenheit = (dblTemp * 1.8) + 32; 
				lblTemp.Text = dblFahrenheit.ToString();
				lblType.Text = "Fahrenheit";


			}
			else
			{
				txtTemp.Text = "";
			}





		}
		private void ConvertToCelsius()
		{
			double dblTemp = 0.0;

			string sTemp = txtTemp.Text;

			if(double.TryParse(sTemp, out dblTemp))
			{
				double dblCelsius = (dblTemp - 32) / 1.8; 
				lblTemp.Text = dblCelsius.ToString();
				lblType.Text = "Celsius";


			}
			else
			{
				txtTemp.Text = "";
			}
		}
		partial void btnConvert_TouchUpInside (UIButton sender)
		{
			if (blnCovertToCelsius)
			{
				ConvertToCelsius();
			
			}
			else
			{
				ConvertToFahrenheit();
			}
		}

		partial void swTempType_ValueChanged (UISwitch sender)
		{
			if (blnCovertToCelsius){
				blnCovertToCelsius =false;
			}
			else
			{
				blnCovertToCelsius = true;
			}
		}
		#endregion
	}
}


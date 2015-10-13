using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using DeathClock.PCL;

namespace DeathClock.IOS
{
	partial class ResultsViewController : UIViewController
	{
		public cPerson User { get; set; }

		private cDeathCalculator oDeath;

		public ResultsViewController (IntPtr handle) : base (handle)
		{
			User = new cPerson ();
			oDeath = new cDeathCalculator ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			imgResultGraphic.Image = UIImage.FromBundle ("Images/clock.png");

		}

		public void CalculateDeath ()
		{
			lblOutput.Text = ResultString (oDeath.FindTimeLeft (User));

		}

		private string ResultString (double yrs)
		{
			string sResult = "";
			sResult += yrs.ToString () + " years left to live.";
			return sResult;

		}
	}
}

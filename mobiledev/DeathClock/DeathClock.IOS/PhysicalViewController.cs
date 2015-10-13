using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using DeathClock.PCL;

namespace DeathClock.IOS
{
	partial class PhysicalVC : UIViewController
	{
		cPerson _User;

		public PhysicalVC (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{

			base.ViewDidLoad ();
			_User = new cPerson ();

		}
	}
}


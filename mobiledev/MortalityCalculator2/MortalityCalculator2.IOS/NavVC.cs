using System;
using UIKit;
using MortalityCalculator.OB;
namespace MortalityCalculator2.IOS
{
	public class NavViewController: UINavigationController
	{
		cPhysicalVC PhysicalViewController;
		cPerson oUser;
		public NavViewController ()
		{
			oUser = new cPerson ();
			PhysicalViewController = new cPhysicalVC (oUser);
			PushViewController (PhysicalViewController, true);
		}
	}
}


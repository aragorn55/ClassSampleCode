// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace DeathClock.IOS
{
	[Register ("ResultsViewController")]
	partial class ResultsViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imgResultGraphic { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblOutput { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		ResultsViewController ResultsVC { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (imgResultGraphic != null) {
				imgResultGraphic.Dispose ();
				imgResultGraphic = null;
			}
			if (lblOutput != null) {
				lblOutput.Dispose ();
				lblOutput = null;
			}
			if (ResultsVC != null) {
				ResultsVC.Dispose ();
				ResultsVC = null;
			}
		}
	}
}

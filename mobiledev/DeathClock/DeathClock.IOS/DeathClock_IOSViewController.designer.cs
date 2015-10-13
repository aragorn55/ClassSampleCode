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
	[Register ("DeathClock_IOSViewController")]
	partial class DeathClock_IOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnCalculate { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		DeathClock_IOSViewController PhysicalVC { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIDatePicker pickBDay { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISegmentedControl segGender { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtFeet { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtInches { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtWeight { get; set; }

		[Action ("btnCalculate_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnCalculate_TouchUpInside (UIButton sender);

		[Action ("pickBDay_ValueChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void pickBDay_ValueChanged (UIDatePicker sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnCalculate != null) {
				btnCalculate.Dispose ();
				btnCalculate = null;
			}
			if (PhysicalVC != null) {
				PhysicalVC.Dispose ();
				PhysicalVC = null;
			}
			if (pickBDay != null) {
				pickBDay.Dispose ();
				pickBDay = null;
			}
			if (segGender != null) {
				segGender.Dispose ();
				segGender = null;
			}
			if (txtFeet != null) {
				txtFeet.Dispose ();
				txtFeet = null;
			}
			if (txtInches != null) {
				txtInches.Dispose ();
				txtInches = null;
			}
			if (txtWeight != null) {
				txtWeight.Dispose ();
				txtWeight = null;
			}
		}
	}
}

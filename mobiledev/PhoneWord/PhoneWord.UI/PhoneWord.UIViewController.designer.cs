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

namespace PhoneWord.UI
{
	[Register ("PhoneWord_UIViewController")]
	partial class PhoneWord_UIViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnCall { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton BtnConvert { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblDisplay { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblOutput { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtInputPhone { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnCall != null) {
				btnCall.Dispose ();
				btnCall = null;
			}
			if (BtnConvert != null) {
				BtnConvert.Dispose ();
				BtnConvert = null;
			}
			if (lblDisplay != null) {
				lblDisplay.Dispose ();
				lblDisplay = null;
			}
			if (lblOutput != null) {
				lblOutput.Dispose ();
				lblOutput = null;
			}
			if (txtInputPhone != null) {
				txtInputPhone.Dispose ();
				txtInputPhone = null;
			}
		}
	}
}

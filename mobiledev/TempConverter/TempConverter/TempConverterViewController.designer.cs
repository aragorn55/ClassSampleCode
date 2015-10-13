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

namespace TempConverter
{
	[Register ("TempConverterViewController")]
	partial class TempConverterViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnConvert { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblInput { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblTemp { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblType { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch swTempType { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtTemp { get; set; }

		[Action ("btnConvert_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnConvert_TouchUpInside (UIButton sender);

		[Action ("swTempType_ValueChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void swTempType_ValueChanged (UISwitch sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnConvert != null) {
				btnConvert.Dispose ();
				btnConvert = null;
			}
			if (lblInput != null) {
				lblInput.Dispose ();
				lblInput = null;
			}
			if (lblTemp != null) {
				lblTemp.Dispose ();
				lblTemp = null;
			}
			if (lblType != null) {
				lblType.Dispose ();
				lblType = null;
			}
			if (swTempType != null) {
				swTempType.Dispose ();
				swTempType = null;
			}
			if (txtTemp != null) {
				txtTemp.Dispose ();
				txtTemp = null;
			}
		}
	}
}

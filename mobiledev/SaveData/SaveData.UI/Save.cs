using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace SaveData.UI
{
	partial class Save : UIViewController
	{
		public override void ViewDidLoad ()
		{
			btnGet1stDatra.TouchUpInside += delegate {
				if (NSUserDefaults.StandardUserDefaults ["Data1"] != null) {
					if (NSUserDefaults.StandardUserDefaults ["Data2"] != null) {
						{

						}
					}
				}
			};
			base.ViewDidLoad ();

		}

		public Save (IntPtr handle) : base (handle)
		{
		}

		partial void btnGet1stDatra_TouchUpInside (UIButton sender)
		{
			throw new NotImplementedException ();
		}

		partial void btn2ndData_TouchUpInside (UIButton sender)
		{
			throw new NotImplementedException ();
		}

		partial void btnSaveData_TouchUpInside (UIButton sender)
		{
			throw new NotImplementedException ();
		}
	}
}

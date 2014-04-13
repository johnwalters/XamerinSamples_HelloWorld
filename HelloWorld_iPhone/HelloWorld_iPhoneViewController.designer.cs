// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace HelloWorld_iPhone
{
	[Register ("HelloWorld_iPhoneViewController")]
	partial class HelloWorld_iPhoneViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnClickMe { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblOutlet { get; set; }

		[Action ("actnBtnClick:")]
		partial void actnBtnClick (MonoTouch.UIKit.UIButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (btnClickMe != null) {
				btnClickMe.Dispose ();
				btnClickMe = null;
			}

			if (lblOutlet != null) {
				lblOutlet.Dispose ();
				lblOutlet = null;
			}
		}
	}
}

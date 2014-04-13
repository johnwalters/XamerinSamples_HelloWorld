using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HelloWorld_iPhone
{
	public partial class HelloWorld_iPhoneViewController : UIViewController
	{
		protected int _numberOfTimesClicked = 0;
		public HelloWorld_iPhoneViewController () : base ("HelloWorld_iPhoneViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			this.btnClickMe.TouchUpInside += (sender, e) => {
				this._numberOfTimesClicked++;
				this.lblOutlet.Text = "Clicked [" + 
					this._numberOfTimesClicked.ToString() + "] times!";
			};
		}

		partial void actnBtnClick (MonoTouch.UIKit.UIButton sender){
			this.lblOutlet.Text = "Action button " + sender.CurrentTitle + " clicked.";
		}
	}
}


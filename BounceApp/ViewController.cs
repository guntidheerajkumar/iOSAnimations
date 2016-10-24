using System;

using UIKit;

namespace BounceApp
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			var Btn = BtnClickMe.Center;
			Btn.X = this.View.Frame.Width + 30;
			BtnClickMe.Center = Btn;
			UIView.AnimateNotify(1.0f, 0f, 1.0f, 1.0f, UIViewAnimationOptions.BeginFromCurrentState, HandleAction, null);
			BtnClickMe.TouchUpInside += (sender, e) => {
				var vc = UIStoryboard.FromName("Main", null).InstantiateViewController("SecondViewController");
				this.NavigationController.PushViewController(vc, true);
			};
		}

		void HandleAction()
		{
			var Btn = BtnClickMe.Center;
			Btn.X = this.View.Frame.Width / 2;
			BtnClickMe.Center = Btn;
		}
	}
}

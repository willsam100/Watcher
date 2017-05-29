using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.Platform;
using Foundation;
using UIKit;
using MvvmCross.Forms.iOS;

namespace Watcher.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register("AppDelegate")]
	public partial class AppDelegate : MvxFormsApplicationDelegate
	{
		private UIWindow _window;

		public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
		{

			_window = new UIWindow(UIScreen.MainScreen.Bounds);
			var setup = new Setup(this, _window);
			setup.Initialize();

			_window.MakeKeyAndVisible();

			LoadApplication(setup.MvxFormsApp);

			return base.FinishedLaunching(uiApplication, launchOptions); ;
		}
	}
}

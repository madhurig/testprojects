using Foundation;
using UIKit;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace IgniteDemo.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			// Code for starting up the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
#endif

			app.ApplicationSupportsShakeToEdit = true;

			MobileCenter.Start("6278b82e-7d8a-4953-896d-9efce9821650",
					typeof(Analytics), typeof(Crashes));

			LoadApplication(new App());


			return base.FinishedLaunching(app, options);
		}
	}
}

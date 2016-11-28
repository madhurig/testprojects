using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using HockeyApp.Android;
using HockeyApp.Android.Metrics;

namespace IgniteDemo.Droid
{
	[Activity(Label = "IgniteDemo.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			CrashManager.Register(this, "b9c89a70b262429d85ec1d17bd9e1dac");
			MetricsManager.Register(Application, "b9c89a70b262429d85ec1d17bd9e1dac");
			//FeedbackManager.Register(this, "b9c89a70b262429d85ec1d17bd9e1dac");

			LoadApplication(new App());
		}
	}
}

using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ImageCircle.Forms.Plugin.Droid;

namespace Workshop.Droid
{
	[Activity (Label = "Workshop.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
			ImageCircleRenderer.Init ();


			LoadApplication (new App ());

            //LoadApplication(UXDivers.Gorilla.Droid.Player.CreateApplication
            //    (ApplicationContext, new UXDivers.Gorilla.Config("Good Gorilla").
            //        RegisterAssemblyFromType<ImageCircle.Forms.Plugin.Abstractions.CircleImage>()));
        }
    }
}

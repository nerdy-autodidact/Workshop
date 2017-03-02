using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using ImageCircle.Forms.Plugin.iOS;
using UIKit;

namespace Workshop.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();
			ImageCircleRenderer.Init ();
			LoadApplication (new App ());

            //LoadApplication(UXDivers.Gorilla.iOS.Player.CreateApplication(
            //                new UXDivers.Gorilla.Config("Good Gorilla")
            //                    .RegisterAssemblyFromType<ImageCircle.Forms.Plugin.Abstractions.CircleImage>()));

            return base.FinishedLaunching (app, options);
		}
	}
}

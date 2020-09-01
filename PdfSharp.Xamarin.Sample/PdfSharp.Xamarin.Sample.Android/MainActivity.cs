using Android.App;
using Android.Content.PM;
using Android.OS;

namespace PdfSharp.Xamarin.Sample.Droid
{
	[Activity(Label = "PdfSharp.Xamarin.Sample", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;
			
            RegisterPackages(bundle);
			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);
			LoadApplication(new App());
		}

        private void RegisterPackages(Bundle bundle)
        {
            //Forms.SetFlags(flags: new string[] { "CarouselView_Experimental", "Expander_Experimental", "Shapes_Experimental", "SwipeView_Experimental" });
            //// Rg.Plugins.Popup.Popup.Init(this, bundle);
            Xamarin.Essentials.Platform.Init(this, bundle);
            //Rg.Plugins.Popup.Popup.Init(this, bundle);
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init(enableFastRenderer: true);
            var ignore = typeof(FFImageLoading.Svg.Forms.SvgCachedImage);
            PdfSharp.Xamarin.Forms.Droid.Platform.Init();
        }
	}
}


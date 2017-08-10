using Android.App;
using Android.Widget;
using Android.OS;

namespace MyAwesomeLibrarySample.Droid
{
    [Activity(Label = "MyAwesomeLibrarySample.Droid", Theme = "@style/MainTheme", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

			global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new MyAwesomeLibrarySample.Forms.App());
        }
    }
}


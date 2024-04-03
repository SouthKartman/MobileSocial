using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms.Platform.Android;

namespace SocialMobilev2
{
    [Activity(Label = "Social", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainApplication : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Добавьте эту строку, чтобы установить цвет шторки
            Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#162127"));

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                Window.SetNavigationBarColor(Android.Graphics.Color.ParseColor("#162127")); // Замените на нужный вам цвет
                Window.SetBackgroundDrawable(new Android.Graphics.Drawables.ColorDrawable(Android.Graphics.Color.ParseColor("#80000000"))); // Уровень прозрачности можно настроить
            }

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

        }
    }
}

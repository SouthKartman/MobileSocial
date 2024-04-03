using SocialMobilev2.Services;
using SocialMobilev2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SocialMobilev2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new Preloader();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

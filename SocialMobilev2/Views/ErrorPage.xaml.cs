using SocialMobilev2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SocialMobilev2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ErrorPage : ContentPage
    {
        public ErrorPage()
        {
            InitializeComponent();
        }

        private void update_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Preloader();
        }
    }
}
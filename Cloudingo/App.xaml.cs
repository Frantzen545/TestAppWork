using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Cloudingo.Views;

namespace Cloudingo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new FilterDashboardPage());
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

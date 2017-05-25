using Android.Content;
using StreetHawkCrossplatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace XamarinEx
{
    public partial class App : Application
    {
        
        
        public App()
        {
            InitializeComponent();

            MainPage = new XamarinEx.MainPage();
        }


        protected override void OnStart()
        {

            // Make sure you have installed and Followed the Analytics Tutorial ! 
            DependencyService.Get<IStreetHawkAnalytics>().SetAppKey("SHPushPing_bison");
            DependencyService.Get<IStreetHawkPush>().RegisterForPushMessaging("1058940905943");
            DependencyService.Get<IStreetHawkAnalytics>().Init();
            DependencyService.Get<IStreetHawkPush>().Register();

            
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

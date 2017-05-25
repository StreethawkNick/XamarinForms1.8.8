using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using XamHawkDemo.Droid;
using Com.Streethawk.Library.Push;

namespace XamarinEx.Droid
{
    [Activity(Label = "XamarinEx", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, ISHObserver
    {
        public void OnReceiveNonSHPushPayload(Bundle p0)
        {
            // Put Break point here 
            String somethingToDo = "do something cool";
        }

        public void OnReceivePushData(PushDataForApplication p0)
        {
            // Put Break point here 
            String somethingToDo = "do something cool";
        }

        public void OnReceiveResult(PushDataForApplication p0, int p1)
        {
            // Put Break point here 
            String somethingToDo = "do something cool";
        }

        public void ShNotifyAppPage(string p0)
        {
            // Put Break point here 
            String somethingToDo = "do something cool";
        }

        // When you Receive your JSON Data, Setup your own Notification
        public void ShReceivedRawJSON(string p0, string p1, string p2)
        {
            // Put Break point here 
            String somethingToDo = "do something cool";
        }


        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            new StreetHawkAnalytics(Application);
            new StreetHawkPush(Application,this);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
            
        }
        


    }
}


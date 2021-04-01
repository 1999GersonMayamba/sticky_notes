using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;

namespace sticky_notes.Droid
{
    [Activity(Label = "NoteCloud", MainLauncher =true, Theme = "@style/Theme.Splash")]
    public class SplashActivity : Activity
    {
        protected  override void OnCreate(Bundle savedInstanceState)
        {
            try
            {
                base.OnCreate(savedInstanceState);
                StartActivity(typeof(MainActivity));
                // Create your application here
            }
            catch (Exception)
            {
                new  NotImplementedException();
            }
        }
    }
}
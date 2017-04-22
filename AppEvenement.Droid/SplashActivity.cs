using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using System.Threading;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AppEvenement.Droid
{
    [Activity(Theme = "@style/Theme.splash ",  MainLauncher = true,NoHistory =true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           
                StartActivity(typeof(MainActivity));
        }
      
    }
}
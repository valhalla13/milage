﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace MilageCalculator.Droid
{
	[Activity(Label = "Milage Calculator", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);



			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it

		}

		public override bool OnCreateOptionsMenu(Android.Views.IMenu menu)
		{
			MenuInflater.Inflate(Resource.Menu.option_menu, menu);
			return base.OnCreateOptionsMenu(menu);
		}
	}
}


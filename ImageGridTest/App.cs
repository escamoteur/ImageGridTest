﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ImageGridTest
{
	public class App : Application
	{
		
		internal static double DisplayScreenWidth;
		internal static double DisplayScreenHeight;
		internal static double DisplayScaleFactor;

		public App ()
		{
			// The root page of your application

			MainPage = new GridPage();
		
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
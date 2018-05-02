
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;
using Xamarin.Forms;
using App1.model;
using App1.bigview;


namespace App1
{
	public partial class App : Application
	{

        Model model;
        public App ()
		{
            model = new Model();
            
			InitializeComponent();

            //MainPage = new App1.bigview.FoodAndWine();
           
            
            MainPage= new NavigationPage(new MainPage(model));
           
            
          
            
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

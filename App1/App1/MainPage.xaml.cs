﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1.model;
using App1.bigview;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        Model model;
        private Button[] b = new Button[6]; 
		public MainPage()
		{
            
			InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
           
           
           
		}
        public MainPage(Model model) {
            this.model = model;
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }

        async private void Ahcd(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ArtandHistory(model));
        }
        async private void Fwcd(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodAndWine(model));

        }
        private void  Oacd(object sender, EventArgs e)
        {
            Console.Write(3);
        }
        async private void Scd(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Shopping(model));
        }
        private void Ecd(object sender, EventArgs e)
        {
            Console.Write(3);
        }

        private void Ctcd(object sender, EventArgs e)
        {
            Console.Write(3);
        }
    }
   
    
}

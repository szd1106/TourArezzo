using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.dataobject;
using App1.bigview;

namespace App1.smallview
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AHsmall : ContentView
    {
        public AHsmall()
        {
            InitializeComponent();
        }

        public AHsmall(AH value)
        {
            InitializeComponent();


            this.AttractionName.Text = value.AttractionName;
            this.AHaddress.Text = value.AHaddress;
            this.AHdistance.Text = "" + value.AHdistance + " mi";

            TapGestureRecognizer tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += async (sender, args) =>
            {
                await Navigation.PushAsync(new bigview.arthistoryDescription(value));
            };
            this.GestureRecognizers.Add(tapGesture);
        }
    }
}
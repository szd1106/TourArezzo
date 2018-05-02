using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        private Button[] b = new Button[6];
        private Label ct = new Label();
        public Page1 ()
		{
			InitializeComponent ();
            b[0] = HP;
            b[1] = SE;
            b[2] = RE;
            b[3] = DT;
            b[4] = PE;
            b[5] = IT;
            ct = ctlabel;
            
            


           
        }
	}
}
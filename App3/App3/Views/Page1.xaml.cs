using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1(string dbPath)
		{
			InitializeComponent();
		}

        async void VRDLSTBTNCLICKED(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Voorraadlijst());
        }

        async void BSHPNBTNCLICKED(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Boodschappenlijst());
        }
        async void INSTBTNCLICKED(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Instellingen());
        }

        async void HLPBTNCLICKED(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Help());
        }
    }
}
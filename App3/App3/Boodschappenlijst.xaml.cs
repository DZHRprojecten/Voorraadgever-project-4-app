using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Boodschappenlijst : ContentPage
	{
		public Boodschappenlijst ()
		{
			InitializeComponent ();
		}

        async void PRDCTLSTBLBTNCLICKED(object sender, System.EventArgs e)
        {
            string targetPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(targetPath, "VoorraadgeverDB.db");

            await Navigation.PushAsync(new MainPage(path));
        }
    }
}
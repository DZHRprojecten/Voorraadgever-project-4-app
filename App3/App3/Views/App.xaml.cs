using App3.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace App3
{
	public partial class App : Application
	{
		public App (string dbPath)
		{
			InitializeComponent();

            //MainPage = new NavigationPage(new Page1(dbPath));
            MainPage = new MasterDetailPage()
            {
                Master = new MainMenuMaster() { Title = "Menu" },
                Detail = new NavigationPage(new Page1(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal)))
            };
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

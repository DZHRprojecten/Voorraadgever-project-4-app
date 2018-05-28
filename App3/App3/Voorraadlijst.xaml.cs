using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using App3.Data;

namespace App3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Voorraadlijst : ContentPage
	{
		public Voorraadlijst ()
		{
			InitializeComponent ();
		}

        async void PRDCTLSTVLBTNCLICKED(object sender, System.EventArgs e)
        {
            string targetPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(targetPath, "VoorraadgeverDB.db");

            await Navigation.PushAsync(new MainPage(path));
        }
        
        private SQLiteAsyncConnection _connection;
        private List<VoorraadlijstDB> _productsSDB;

        public Voorraadlijst(string dbPath)
        {
            _connection = new SQLiteAsyncConnection(dbPath);
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            await _connection.CreateTableAsync<VoorraadlijstDB>();
            var Voorraden = await _connection.Table<VoorraadlijstDB>().ToListAsync();
            _productsSDB = new List<VoorraadlijstDB>(Voorraden);
            Voorraadlijstview.ItemsSource = _productsSDB;
            base.OnAppearing();
        }
    }

}

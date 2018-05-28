using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App3.Data;
using SQLite;


namespace App3
{
	public partial class MainPage : ContentPage
	{
        private SQLiteAsyncConnection _connection;
        private List<StandaardDB> _productsSDB;

        public MainPage(string dbPath)
        {
            _connection = new SQLiteAsyncConnection(dbPath);
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            await _connection.CreateTableAsync<StandaardDB>();
            var doggos = await _connection.Table<StandaardDB>().ToListAsync();
            _productsSDB = new List<StandaardDB>(doggos);
            productDB.ItemsSource = _productsSDB;
            base.OnAppearing();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SQLite;

namespace App1.Droid
{
    [Activity(Label = "App1", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        //protected override void OnCreate(Bundle bundle)
        //{
        //    //private List<Grocery_list> mItems;
        //    //private ListView mListview;
                

        //    TabLayoutResource = Resource.Layout.Tabbar;
        //    ToolbarResource = Resource.Layout.Toolbar;


         private List<string> Items;
         private ListView ListView;
         private Button NewButton, UpdateButton, CleanButton;
         private EditText Input;
         private ArrayAdapter<string> Adapter;


            //base.OnCreate(bundle);
        //string targetPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        //var path = Path.Combine(targetPath, "VoorraadgeverDB.db");

        //if (!File.Exists(path))
        //{
        //    using (Stream input = Assets.Open("VoorraadgeverDB.db"))
        //    {
        //        using (var fs = new FileStream(path, FileMode.Create))
        //        {
        //            input.CopyTo(fs);
        //        }
        //    }
        //}
        // Set our view from the "main" layout resource
        //SetContentView(Resource.Layout.Main);
        //mListview = FindViewById<ListView>(Resource.Id.Mainmenulist);

        //mItems = new List<Grocery_list>();

        //mItems.Add(new Grocery_list() { FirstName = "John", LastName = "Smith", Age = "22", Gender = "Male" });
        //mItems.Add(new Grocery_list() { FirstName = "Tom", LastName = "Tucker", Age = "25", Gender = "Male" });
        //mItems.Add(new Grocery_list() { FirstName = "Sally", LastName = "Smith", Age = "20", Gender = "Female" });

        //Mylistviewadaptermainmenu adapter = new Mylistviewadaptermainmenu(this, mItems);

        //// gebruik dit om specifieke items te selecteren string indexerTest = adapter.mItems[1];

        //mListview.Adapter = adapter;
        //#region Buttons

        //Buttons.Add(new ButtonAction(NewButton, () =>
        //    {
        //    if (Input.Text != "")
        //    {
        //        Person test = new Person(1, Input.Text, "0123546", "test@hr.nl");
        //        db.Insert(test);
        //    }
        //}));

        //Buttons.Add(new ButtonAction(UpdateButton, () =>
        //{
        //    IEnumerable<Person> Query;
        //    if (Input.Text != "")
        //    {
        //        Query = db.SelectFrom<Person>("SELECT * FROM Person WHERE Name =? AND Id=? ", new[] { Input.Text, "1" });
        //    }
        //    else
        //    {
        //        Query = db.SelectFrom<Person>("SELECT * FROM Person");
        //    }

        //    Items.Clear();
        //    foreach (var row in Query.ToList())
        //    {
        //        Items.Add(row.ToString());
        //    }
        //    Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, Items);
        //    ListView.Adapter = Adapter;
        //  }));

    }
}


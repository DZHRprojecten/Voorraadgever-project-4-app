using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    //class Mylistviewadaptermainmenu : BaseAdapter<Grocery_list>
    //{
    //    public List<Grocery_list> mItems;
    //    Context mContext;

    //    public Mylistviewadaptermainmenu(Context context, List<Grocery_list> items)
    //    {
    //        mItems = items;
    //        mContext = context;
    //    }
    //    public override int Count
    //    {
    //        get { return mItems.Count; }
    //    }

    //    public override long GetItemId(int position)
    //    {
    //        return position;
    //    }

    //    public override Grocery_list this[int position]
    //    {
    //        get { return mItems[position]; }
    //    }

    //    public override View GetView(int position, View convertView, ViewGroup parent)
    //    {
    //        View row = convertView;

    //        if (row == null)
    //        {
    //            row = LayoutInflater.From(mContext).Inflate(Resource.Layout.Listviewrowmainmenu, null, false);
    //        }

    //        TextView textFirstnamemainmenu = row.FindViewById<TextView>(Resource.Id.textFirstnamemainmenu);
    //        textFirstnamemainmenu.Text = mItems[position].FirstName;

    //        TextView textLastnamemainmenu = row.FindViewById<TextView>(Resource.Id.textLastnamemainmenu);
    //        textLastnamemainmenu.Text = mItems[position].LastName;

    //        TextView textAgemainmenu = row.FindViewById<TextView>(Resource.Id.textAgemainmenu);
    //        textAgemainmenu.Text = mItems[position].Age;

    //        TextView textGendermainmenu = row.FindViewById<TextView>(Resource.Id.textGendermainmenu);
    //        textGendermainmenu.Text = mItems[position].Gender;

    //        return row;
    //    }
    //}
}

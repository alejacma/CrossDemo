using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Collections.ObjectModel;
using CrossPCL.Models;

namespace AndroidApp
{
    public class ItemsAdapter : BaseAdapter
    {
        private ObservableCollection<Item> itemList;
        private Activity activity;

        public ItemsAdapter(Activity activity, ObservableCollection<Item> itemList)
        {
            this.activity = activity;
            this.itemList = itemList;
        }

        public override int Count
        {
            get { return this.itemList.Count; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            // could wrap a Item in a Java.Lang.Object
            // to return it here if needed
            return null;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? this.activity.LayoutInflater.Inflate(Resource.Layout.Item, parent, false);
            var name = view.FindViewById<TextView>(Resource.Id.Name);
            var description = view.FindViewById<TextView>(Resource.Id.Description);
            
            name.Text = this.itemList[position].Name;
            description.Text = this.itemList[position].Description;

            return view;
        }

    }

}
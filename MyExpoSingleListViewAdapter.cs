﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ExpoApp.Models;

namespace ExpoApp.Droid
{
    class MyExpoSingleListViewAdapter : BaseAdapter<Expo>
    {
        public List<Expo> mItems;
        public Context mContext;

        public MyExpoSingleListViewAdapter(List<Expo> mItems, Context mContext)
        {
            this.mItems = mItems;
            this.mContext = mContext;
        }

        public override Expo this[int position]
        {
            get { return mItems[position]; }
        }


        public override int Count
        {
            get { return mItems.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.MyExposSingle, null, false);
            }
            TextView txtName = row.FindViewById<TextView>(Resource.Id.MyExpoSingleName);
            txtName.Text = mItems[position].Name_Expo;

            return row;
        }
    }
}
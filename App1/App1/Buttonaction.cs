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

namespace App1.Product
{
    class ButtonAction
    {
        private Button Button;
        private Action Action;
        public ButtonAction(Button button, Action action)
        {
            this.Button = button;
            this.Action = action;
        }

        public void Activate()
        {
            Button.Click += delegate { Action(); };
        }
    }
}
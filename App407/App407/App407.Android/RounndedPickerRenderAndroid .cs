using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App407;
using App407.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RoundPicker), typeof(RounndedPickerRenderAndroid))]
namespace App407.Droid
{
    class RounndedPickerRenderAndroid : PickerRenderer
    {
        private AlertDialog _dialog;
        IElementController ElementController => Element as IElementController;
        public RounndedPickerRenderAndroid(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {

                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(0f);
                gradientDrawable.SetStroke(2,
    Android.Graphics.Color.LightGray);
                gradientDrawable.SetColor(Android.Graphics.Color.White);
                Control.SetBackground(gradientDrawable);
                Control.SetHintTextColor(Android.Graphics.Color.Gray);
                Control.SetPadding(20, 0, 0, 0);
                Control.SetSingleLine(true);

                //Control.Click += Control_Click;
            }

        }

        private void Control_Click(object sender, EventArgs e)
        {
            Console.WriteLine("1312321");
        }
    }
}
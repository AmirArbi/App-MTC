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
using AppMTC;
using AppMTC.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using static Java.Util.ResourceBundle;

[assembly: ExportRenderer(typeof(MyFrame), typeof(MyFrameRenderer))]
namespace AppMTC.Droid
{
    public class MyFrameRenderer : FrameRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);

            GradientDrawable gradientDrawable = new GradientDrawable();
            gradientDrawable.SetShape(ShapeType.Rectangle);
            gradientDrawable.SetColor(Element.BackgroundColor.ToAndroid());
            gradientDrawable.SetStroke(4, Color.FromRgb(201, 201, 201).ToAndroid());
            gradientDrawable.SetCornerRadius(20);
        }
    }
}
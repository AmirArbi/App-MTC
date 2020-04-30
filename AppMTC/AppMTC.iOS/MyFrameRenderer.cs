using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppMTC;
using AppMTC.iOS;
using CoreGraphics;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyFrame), typeof(MyFrameRenderer))]

namespace AppMTC.iOS
{
    public class MyFrameRenderer : FrameRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);
            this.Layer.CornerRadius = 18;
            this.Layer.Bounds.Inset(1, 1);
            Layer.BorderColor = UIColor.White.CGColor;
            Layer.BorderWidth = 2;
            Layer.BackgroundColor = Color.Transparent.ToCGColor();
        }
    }
}
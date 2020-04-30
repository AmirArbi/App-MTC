using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppMTC
{
    public class CustomEntry : Entry
    {
        public static readonly BindableProperty IconProperty = BindableProperty.Create(nameof(Icon), typeof(string), typeof(CustomEntry), string.Empty);

        /// <summary>
        /// Icon file used in Entry
        /// </summary>
        public string Icon
        {
            get => (string)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }
    }
}

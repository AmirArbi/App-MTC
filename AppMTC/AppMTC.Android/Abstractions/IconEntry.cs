using System;
using Xamarin.Forms;

namespace Abstractions
{
    internal class IconEntry
    {
        public static object IconProperty { get; internal set; }

        public static explicit operator IconEntry(Entry v)
        {
            throw new NotImplementedException();
        }
    }
}
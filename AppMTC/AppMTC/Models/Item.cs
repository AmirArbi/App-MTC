using System;

namespace AppMTC.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Subtitle { get; set; }
        public int Type { get; set; }
        public int Date { get; set; }
        public string Location { get; set; }
        public string Text { get; set; }
    }
}
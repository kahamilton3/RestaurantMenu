using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        private string name;
        private double price;
        private string description;
        private string category;
        private bool newItem;
        public MenuItem(string name, double price, string description, string category, bool newItem)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.category = category;
            this.newItem = newItem;
        }
        public MenuItem(string name, double price, string description, string category)
     : this(name, price, description, category, true) { }
        public string Name
        {
            get { return name; }
        }
        public double Price
        {
            get { return price; }
        }
        public string Description
        {
            get { return description; }
        }
        public string Category
        {
            get { return category; }
        }
        public bool NewItem
        {
            get { return newItem; }
        }

    }
}

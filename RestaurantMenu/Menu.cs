using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace RestaurantMenu
{
    class Menu : IEnumerable<MenuItem>
    {
        private DateTime lastUpdated;
        private List<MenuItem> menuItems;
        public Menu(List<MenuItem> menuItems)
        {
            this.menuItems = menuItems;
        }
        public DateTime LastUpdated
        {
            get { return lastUpdated; }
        }
        public List<MenuItem> MenuItems { get; set; }
        public IEnumerator<MenuItem> GetEnumerator()
        {
            return menuItems.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return menuItems.GetEnumerator();
        }
        public void AddMenuItem(string name, double price, string description, string category)
        {
            MenuItem newItem = new MenuItem(name, price, description, category);
            menuItems.Add(newItem);
            DateTime now = DateTime.Now;
            lastUpdated = now;
        }
    }
}
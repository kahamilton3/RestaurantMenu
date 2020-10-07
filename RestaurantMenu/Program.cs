using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem appOne = new MenuItem("Wings", 4.99, "Bone-in chicken wings tossed in buffalo sauce", "Appetizer", false);
            MenuItem mainOne = new MenuItem("Steak", 29.99, "yummm", "Main Course", false);
            MenuItem dessertOne = new MenuItem("Ice-Cream Sundae", 2.99, "Classic Dessert!", "Dessert", false);
            List<MenuItem> originalItems = new List<MenuItem> { appOne, mainOne, dessertOne};
            Menu newMenu = new Menu(originalItems);
            newMenu.AddMenuItem("Chicken Nachos", 7.99, "chips, cheese, chicken... good.", "Appetizer");
            newMenu.AddMenuItem("Salmon", 14.99, "straight from the sea", "Main Course");
            newMenu.AddMenuItem("Cheesecake", 5.99, "Crowd favorite", "Dessert");
            Console.WriteLine("Here is my Menu!");
            Console.WriteLine("LastUpdated: " + newMenu.LastUpdated);
            Console.WriteLine(" ");
            foreach (MenuItem item in newMenu)
            {
                if (item.NewItem == true)
                {
                    Console.WriteLine("NEW!");
                }
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Category);
                Console.WriteLine(item.Description);
                Console.WriteLine("$" + item.Price);
                Console.WriteLine(" ");
            }
        }
    }
}

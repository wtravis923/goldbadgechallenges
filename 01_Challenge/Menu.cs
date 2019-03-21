using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class Menu
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public decimal Price { get; set; }
        //This allows you to add the above props to the list below. 
        public List<Menu> MenuList { get; set; }

        public Menu(int number, string name, string description, string ingredients, decimal price)
        {
            MealNumber = number;
            MealName = name;
            Description = description;
            Ingredients = ingredients;
            Price = price;
            MenuList = new List<Menu>();
        }

        public Menu()
        {
            MenuList = new List<Menu>();
        }
    }
}

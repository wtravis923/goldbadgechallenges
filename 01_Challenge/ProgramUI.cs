using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class ProgramUI
    {
        private Menu _menu; 
        private MenuRepository _menuRepo;

        public ProgramUI()
        {
            _menu = new Menu();
        }
        public void Run()
        {

            bool running = true; 
            while (running)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do? \n" +
                    "1. Create a New Menu Item\n" +
                    "2. View Menu Items\n" +
                    "3. Remove a Menu Item\n" +
                    "4. Exit Application");

                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

                switch (input)
                {
                    case 1:
                        CreateNewItem();
                        break;
                    case 2:
                        ViewItems();
                        break;
                    case 3:
                        RemoveItems();
                        break;
                    case 4:
                        running = false;
                        break; 
                }
            }

        }

        private void CreateNewItem()
        {
            Console.WriteLine("Enter the name of the menu item:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the menu combo number:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the item description:");
            string description = Console.ReadLine();

            Console.WriteLine("Enter the item ingredients:");
            string ingredients = Console.ReadLine();

            Console.WriteLine("Enter the item price:");
            decimal price = decimal.Parse(Console.ReadLine());

            //Exact order that you specified class. 
            Menu menuToList = new Menu(number, name, description, ingredients, price);

            _menuRepo.CreateNewMenuItem(menuToList); 
        }

        private void ViewItems()
        {
            List<Menu> menu = _menuRepo.GetMenuList();

            foreach (Menu menuItems in menu)
            {
                Console.WriteLine($"Combo #{menuItems.MealNumber}\n " +
                    $"Meal Name: {menuItems.MealName}\n " +
                    $"Description: {menuItems.Description}\n " +
                    $"Ingredients: {menuItems.Ingredients}\n " +
                    $"Price: {menuItems.Price.ToString("C2")}");

            }
                Console.ReadLine(); 
        }
        private void RemoveItems()
        {
            ViewItems();

            Console.WriteLine("What is the menu combo number you would like to remove?");
            int number = int.Parse(Console.ReadLine());

            bool success = _menuRepo.RemoveMenuItems(number); 
            if (success == true)
            {
                Console.WriteLine($"Combo {number} was successfully removed. Press any button to continue.");
                Console.ReadKey(); 
            }
            else
            {
                Console.WriteLine($"Combo {number} was unable to be removed at this time.");
                Console.ReadKey();
                Console.Clear();
            }

        }

    }  
}

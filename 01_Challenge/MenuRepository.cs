using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class MenuRepository
    {
        private List<Menu> _menuItems = new List<Menu>();

        public void CreateNewMenuItem(Menu menu)
        {
            _menuItems.Add(menu);
        }

        public List<Menu> GetMenuList()
        {
            return _menuItems; 
        }

        public void RemoveMenuItems(Menu menu)
        {
            _menuItems.Remove(menu); 
        }

        public bool RemoveMenuItems(int mealNumber)
        {
            bool successful = false;
            foreach (Menu menu in _menuItems)
            {
                if (menu.MealNumber == mealNumber)
                {
                    RemoveMenuItems(menu);
                    successful = true;
                    break; 
                }
            }

            return successful; 
        }
    }
}

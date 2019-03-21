using System;
using _01_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_ChallengeTests
{
    [TestClass]
    public class MenuRepositoryTests
    {
        private MenuRepository _menuRepo;

        [TestMethod]
        public void MenuRepository_AddItemToList()
        {
            //Arrange
            MenuRepository _menuRepo = new MenuRepository();
            Menu itemone = new Menu();
            Menu itemtwo = new Menu();
            Menu itemthree = new Menu();

            _menuRepo.CreateNewMenuItem(itemone);
            _menuRepo.CreateNewMenuItem(itemtwo);
            _menuRepo.CreateNewMenuItem(itemthree);

            //Act
            int actual = _menuRepo.GetMenuList().Count;
            int expected = 3;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepository_RemoveItemfromList()
        {
            //Arrange
            MenuRepository _menuRepo = new MenuRepository();
            Menu itemone = new Menu();
            Menu itemtwo = new Menu();
            Menu itemthree = new Menu();

            _menuRepo.CreateNewMenuItem(itemone);
            _menuRepo.CreateNewMenuItem(itemtwo);
            _menuRepo.CreateNewMenuItem(itemthree);

            _menuRepo.RemoveMenuItems(itemone); 

            //Act
            int actual = _menuRepo.GetMenuList().Count;
            int expected = 2;

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}

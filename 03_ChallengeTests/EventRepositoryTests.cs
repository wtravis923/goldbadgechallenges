using System;
using _03_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_ChallengeTests
{
    [TestClass]
    public class EventRepositoryTests
    {

        private EventRepository _eventRepo; 

        [TestMethod]
        public void EventRepository_AddEventToList()
        {
            //Arrange
            EventRepository _eventRepo = new EventRepository();
            Events eventone = new Events();
            Events eventtwo = new Events();
            Events eventthree = new Events();

            _eventRepo.AddEventToList(eventone);
            _eventRepo.AddEventToList(eventtwo);
            _eventRepo.AddEventToList(eventthree);

            //Act
            int actual = _eventRepo.GetEvents().Count;
            int expected = 3;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

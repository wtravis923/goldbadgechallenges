using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public class ProgramUI
    {
        private Events _eventList;
        private EventRepository _eventRepo = new EventRepository();
        //List<Events> _eventList = new List<Events>();
        List<Events> _golfList = new List<Events>();
        List<Events> _parkList = new List<Events>();
        List<Events> _bowlingList = new List<Events>();
        List<Events> _concertList = new List<Events>();


        public ProgramUI()
        {
            _eventList = new Events();
        }

        public void Run()
        {
            
            bool running = true; 
            while (running)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do? \n" +
                    "1. Add an Event\n" +
                    "2. View Event Information\n" +
                    "3. Exit Application");

                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString); 

                switch (input)
                {
                    case 1:
                        AddEventToList();
                        break;
                    case 2:
                        GetEvents();
                        break;
                    case 3:
                        running = false;
                        break; 
                }
            }
        }

        private void AddEventToList()
        {
            Console.Clear();
            Console.WriteLine("Please select the event type:\n" +
                "1. Amusement Park\n" +
                "2. Bowling\n" +
                "3. Concert\n" +
                "4. Golf ");
            string inputAsString = Console.ReadLine();
            int input = int.Parse(inputAsString);

            Event type = new Event(); 
            switch (input)
            {
                case 1:
                    type = Event.AmusementPark;
                    break;

                case 2:
                    type = Event.Bowling;
                    break;

                case 3:
                    type = Event.Concert;
                    break;

                case 4:
                    type = Event.Golf;
                    break; 
            }
            

            Console.WriteLine("Please enter the date of the event:");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of attendees:");
            int attendees = int.Parse(Console.ReadLine());

            Console.WriteLine("What was the cost per attendee?");
            decimal individualCost = decimal.Parse(Console.ReadLine());

            Events eventsToList = new Events(date, type, attendees, individualCost);

            _eventRepo.AddEventToList(eventsToList); 
        }

        private void GetEvents()
        {

            List<Events> events = _eventRepo.GetEvents();
            List<Events> _eventList = _eventRepo.GetEvents();
            List<Events> _golfList = _eventRepo.GetGolfEvents();
            List<Events> _concertList = _eventRepo.GetConcertEvents();
            List<Events> _parksList = _eventRepo.GetAmusementParkEvents();
            List<Events> _bowlingList = _eventRepo.GetBowlingEvents();

            Console.Clear();
            Console.WriteLine("What would you like to do?\n" +
                "1. View Event Details & Total Cost\n" +
                "2. View Specific Event Type Details & Total Cost");

            string inputAsString = Console.ReadLine();
            int input = int.Parse(inputAsString);

            switch (input)
            {
                case 1:
                    ViewEventList();
                    break;

                case 2:
                    ViewCostOfEvents();
                    break;
            }


                Console.ReadLine();
        }
        
        private void ViewEventList ()
        {
            List<Events> _eventList = _eventRepo.GetEvents(); 
                Console.Clear(); 
            foreach (Events eventItems in _eventList)
            {
                Console.WriteLine($"Date: {eventItems.Date.ToString("d")}\n" +
                    $"Event Type: {eventItems.EventType}\n" +
                    $"Number of attendees: {eventItems.Attendees}\n" +
                    $"Cost per attendee: {eventItems.IndividualCost.ToString("c")}\n" +
                    $"Total cost of event: {eventItems.IndividualEventCost.ToString("c")}\n");
            }
            Console.WriteLine($"Total Cost of All Events = {_eventRepo.CalculateTotalCost(_eventList).ToString("C2")}");

            Console.ReadKey(); 
        }

        private void ViewCostOfEvents()
        {
            List<Events> events = _eventRepo.GetEvents();
            List<Events> _golfList = _eventRepo.GetGolfEvents();
            List<Events> _concertList = _eventRepo.GetConcertEvents();
            List<Events> _parksList = _eventRepo.GetAmusementParkEvents();
            List<Events> _bowlingList = _eventRepo.GetBowlingEvents();

            List<Events> _eventList = _eventRepo.GetEvents();
            foreach (Events eventItems in _golfList)
            {
                Console.WriteLine($"Date: {eventItems.Date.ToString("d")}\n" +
                    $"Event Type: {eventItems.EventType}\n" +
                    $"Number of attendees: {eventItems.Attendees}\n" +
                    $"Cost per attendee: {eventItems.IndividualCost.ToString("c")}\n" +
                    $"Total cost of event: {eventItems.IndividualEventCost.ToString("c")}\n");

            }
                Console.WriteLine($"Total Cost of Golf Events: {_eventRepo.CalculateTotalCost(_golfList).ToString("C2")}");

            foreach (Events eventItems in _concertList)
            {
                Console.WriteLine($"Date: {eventItems.Date.ToString("d")}\n" +
                    $"Event Type: {eventItems.EventType}\n" +
                    $"Number of attendees: {eventItems.Attendees}\n" +
                    $"Cost per attendee: {eventItems.IndividualCost.ToString("c")}\n" +
                    $"Total cost of event: {eventItems.IndividualEventCost.ToString("c")}\n");
            }
                Console.WriteLine($"Total Cost of Concert Events: {_eventRepo.CalculateTotalCost(_concertList).ToString("c")}");

            foreach (Events eventItems in _parksList)
            {
                Console.WriteLine($"Date: {eventItems.Date.ToString("d")}\n" +
                    $"Event Type: {eventItems.EventType}\n" +
                    $"Number of attendees: {eventItems.Attendees}\n" +
                    $"Cost per attendee: {eventItems.IndividualCost.ToString("c")}\n" +
                    $"Total cost of event: {eventItems.IndividualEventCost.ToString("c")}\n");
            }
                Console.WriteLine($"Total Cost of Amusement Park Events: {_eventRepo.CalculateTotalCost(_parksList).ToString("c")}");

            foreach (Events eventItems in _bowlingList)
            {
                Console.WriteLine($"Date: {eventItems.Date.ToString("d")}\n" +
                    $"Event Type: {eventItems.EventType}\n" +
                    $"Number of attendees: {eventItems.Attendees}\n" +
                    $"Cost per attendee: {eventItems.IndividualCost.ToString("c")}\n" +
                    $"Total cost of event: {eventItems.IndividualEventCost.ToString("c")}\n");
            }
                Console.WriteLine($"Total Cost of Bowling Events: {_eventRepo.CalculateTotalCost(_bowlingList).ToString("c")}");
        }
    }
}

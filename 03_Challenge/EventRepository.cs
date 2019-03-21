using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public class EventRepository
    {
        
        private List<Events> _eventList = new List<Events>();
        private List<Events> _golfList = new List<Events>();
        private List<Events> _parksList = new List<Events>();
        private List<Events> _bowlingList = new List<Events>();
        private List<Events> _concertList = new List<Events>();
        Events _event = new Events();
        
        public void AddEventToList (Events events)
        {
            _eventList.Add(events); 
        }
        
        public List<Events> GetEvents()
        {
            return _eventList; 
        }

        public decimal CalculateEventCost(Event eventType)
        {
            decimal eventCost = 0m;
            
            switch (eventType)
            {
                case Event.AmusementPark:
                    eventCost = _event.IndividualEventCost;
                    List<Events> _parksList = new List<Events>();
                    break;

                case Event.Bowling:
                    eventCost = _event.IndividualEventCost;
                    List<Events> _bowlingList = new List<Events>();
                    break;

                case Event.Concert:
                    eventCost = _event.IndividualEventCost;
                    List<Events> _concertList = new List<Events>();
                    break;

                case Event.Golf:
                    eventCost = _event.IndividualEventCost;
                    List<Events> _golfList = new List<Events>();
                    break;
            }

            return eventCost;
        }

        public List<Events> GetGolfEvents()
        {
            return _golfList;
        }

        public List<Events> GetAmusementParkEvents()
        {
            return _parksList;
        }

        public List<Events> GetConcertEvents()
        {
            return _concertList;
        }

        public List<Events> GetBowlingEvents()
        {
            return _bowlingList;
        }

        public decimal CalculateTotalCost(List<Events> events) 
        {
            decimal totalCost = 0m;
            List<Events> allEvents = events;
            
            foreach (Events _eventsList in allEvents)
            {
                totalCost += _eventsList.IndividualEventCost;
            }

            return totalCost; 
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
        public enum Event { Golf, Bowling, AmusementPark, Concert }

    public class Events
    {
        //Properties
        public int Attendees { get; set; }
        public DateTime Date { get; set; }
        public decimal IndividualCost { get; set; }
        public decimal IndividualEventCost { get; set; }
        public decimal TotalCostByTypeOfEvent { get; set; }
        public Event EventType { get; set; }
        public List<Events> _eventList { get; set; }
        public List<Events> _golfList { get; set; }
        public List<Events> _bowlingList { get; set; }
        public List<Events> _parksList { get; set; }
        public List<Events> _concertList { get; set; }

        //Constructors
        public Events(DateTime date, Event eventType, int attendees, decimal individualCost)
        {
            Attendees = attendees;
            EventType = eventType;
            Date = date;
            IndividualCost = individualCost;
            IndividualEventCost = attendees * individualCost;
        }

        //Blank Constructor
        public Events() { }
    }
}

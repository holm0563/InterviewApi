using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewEndpoints.Models;

namespace InterviewEndpoints.Service
{
    public class SimpleData
    {
        public static SimpleData Instance = _instance ?? (_instance = new SimpleData());

        private static SimpleData _instance;

        public IList<Flight> Flights { get; set; }

        public IList<Station> Stations { get; set; }

        private SimpleData()
        {
            Reset();
        }

        public void Reset()
        {
            Stations = new List<Station>
            {
                new Station
                {
                    Name = "Salt Lake City",
                    Code = "SLC"
                },
                new Station
                {
                    Name = "John F Kennedy",
                    Code = "JFK"
                },
                new Station
                {
                    Name = "Denver",
                    Code = "DEN"
                },
                new Station
                {
                    Name = "Atlanta",
                    Code = "ATL"
                }
            };

            Flights = new List<Flight>
            {
                new Flight
                {
                    Arrival = DateTime.Today.AddHours(10),
                    Departure = DateTime.Today.AddHours(2),
                    Destination = "JFK",
                    Origin = "SLC",
                    Key = Guid.NewGuid().ToString(),
                    Number = "3342"
                },
                new Flight
                {
                    Arrival = DateTime.Today.AddHours(5),
                    Departure = DateTime.Today.AddHours(4),
                    Destination = "DEN",
                    Origin = "SLC",
                    Key = Guid.NewGuid().ToString(),
                    Number = "2211"
                },
                new Flight
                {
                    Arrival = DateTime.Today.AddHours(38),
                    Departure = DateTime.Today.AddHours(30),
                    Destination = "JFK",
                    Origin = "DEN",
                    Key = Guid.NewGuid().ToString(),
                    Number = "9877"
                }
            };
        }
    }
}

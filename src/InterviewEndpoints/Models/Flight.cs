using System;
using System.ComponentModel.DataAnnotations;

namespace InterviewEndpoints.Models
{
    public class Flight: FlightBase
    {
        public Flight(FlightBase flight)
        {
            this.Arrival = flight.Arrival;
            this.Departure = flight.Departure;
            this.Destination = flight.Destination;
            this.Number = flight.Origin;
            this.Origin = flight.Origin;

            Key = Guid.NewGuid().ToString();
        }

        public Flight()
        {
            
        }

        public string Key { get; set; }
    }
}
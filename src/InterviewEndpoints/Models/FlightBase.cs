using System;
using System.ComponentModel.DataAnnotations;

namespace InterviewEndpoints.Models
{
    public class FlightBase
    {
        [Required]
        public string Number { get; set; }

        [Required]
        public string Destination { get; set; }

        [Required]
        public string Origin { get; set; }

        [Required]
        public DateTime? Arrival { get; set; }

        [Required]
        public DateTime? Departure { get; set; }
    }
}
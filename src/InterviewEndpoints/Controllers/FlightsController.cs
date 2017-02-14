#region Copyright
// ==================================================================================================
//   This file is part of the Navitaire dotREZ application.
//   Copyright © 2017 Navitaire LLC  An Amadeus company. All rights reserved.
// ==================================================================================================
#endregion

using System;
using System.Collections.Generic;
using InterviewEndpoints.Models;
using InterviewEndpoints.Service;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace InterviewEndpoints.Controllers
{
    [Route("api/[controller]")]

    public class FlightsController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            return SimpleData.Instance.Flights;
        }

        [HttpGet("{key}", Name = "GetFlight")]
        public Flight GetByKey([FromRoute] string key)
        {
            return SimpleData.Instance.Flights.FirstOrDefault(t => t.Key == key);
        }

        [HttpDelete("{key}")]
        public void Delete([FromRoute] string key)
        {
            var item = SimpleData.Instance.Flights.FirstOrDefault(t => t.Key == key);

            if (item == null)
            {
                return;
            }

            SimpleData.Instance.Flights.Remove(item);
        }

        [HttpPost]
        public IActionResult Add([FromBody] FlightBase flight)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var data = new Flight(flight);

            SimpleData.Instance.Flights.Add(data);

            return Ok(data); //CreatedAtRoute("GetFlight", new {key = data.Key});
        }

    }
}
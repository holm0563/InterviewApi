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

    public class StationsController : Controller
    {
        [HttpGet]
        public IEnumerable<Station> Get()
        {
            return SimpleData.Instance.Stations;
        }


    }
}
#region Copyright

// ==================================================================================================
//   This file is part of the Navitaire dotREZ application.
//   Copyright © 2017 Navitaire LLC  An Amadeus company. All rights reserved.
// ==================================================================================================

#endregion

using InterviewEndpoints.Service;
using Microsoft.AspNetCore.Mvc;

namespace InterviewEndpoints.Controllers
{
    [Route("api/[controller]")]
    public class AdminController : Controller
    {
        [HttpPost]
        public void Reset()
        {
            SimpleData.Instance.Reset();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieHub.Dtos;

namespace MovieHub.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalsDto newRental)
        {
            throw new NotImplementedException();
        }
    }
}

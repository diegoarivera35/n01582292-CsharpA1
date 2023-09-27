using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01582292TestApp.Controllers
{
    public class GreetingController : ApiController
    {
        // just entering the url /api/greeting and getting back a simple string
        public string Get()
        {

            return "Hello World!";
        }
    }
}

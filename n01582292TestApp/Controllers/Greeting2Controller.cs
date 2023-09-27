using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01582292TestApp.Controllers
{
    public class Greeting2Controller : ApiController
    {
        // sent an id to get back an string with the integer in it
        public string Get(int id)
        {
            string Greeting = "Greetings to " + id + " people!";
            return Greeting;
        }
    }
}

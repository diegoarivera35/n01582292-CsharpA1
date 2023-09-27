using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01582292TestApp.Controllers
{
    public class SquareController : ApiController
    {
        // sent an id(integer) to square it by multiplying it by itself
        public int Get(int id)
        {
            int Square = id * id;
            return Square;
        }

    }
}

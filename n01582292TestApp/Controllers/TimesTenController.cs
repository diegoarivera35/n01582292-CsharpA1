using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01582292TestApp.Controllers
{
    public class AddTenController : ApiController
    {
        // sent an id (integer) to add 10 and get back the result(integer)
        public int Get(int id) 
        {
            int Suma = 10 + id;
            return Suma;
        }
            
        
    }
}

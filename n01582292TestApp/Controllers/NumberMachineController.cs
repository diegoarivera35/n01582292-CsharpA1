using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01582292TestApp.Controllers
{
    public class NumberMachineController : ApiController
    {
        //send an id to complete 4 mathematical operations with it and show the result
        public int Get(int id)
        {
            int result =  ((((id + 50) -10) * 7) / 2);

            return result;
        }

    }
}

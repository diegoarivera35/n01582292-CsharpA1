using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01582292TestApp.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// calculate the price for fortnights with an addition of the days already provided, add the tax to that
        /// </summary>
        /// <param name="id">the amount of days already elapsed</param>
        /// <returns>
        // id+ " fortnights at $5.50 / FN = $" + FN +" CAD " + -> the the number of days (ID) plus 14 days of fortnights * 5.50CAD
        // "HST 13 % = $ "+ HST +" CAD " + -> FN * the 13% to get the tax
        // "Total = $"+Total + "CAD " -> ad the taz and the price for the fortnights to get the total
        /// </returns>

        public string Get(int id)
        {
            
            int Fortnights = (id + 14) /14;

            // “1 fortnights at $5.50 / FN = $5.50 CAD”
            // “HST 13 % = $0.72 CAD”
            //  “Total = $6.22 CAD”

            double FN = (Fortnights * 5.50);
            double HST = FN * 0.13;
            double Total = FN + HST;
            return  id+ " fortnights at $5.50 / FN = $" + FN +" CAD " +
            "HST 13 % = $ "+ HST +" CAD " +
            "Total = $"+Total + "CAD ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace practice1.Controllers
{
    public class HostController : ApiController
    { //// hostcost = (<=13) is $5.5, (>=14 or <=27) is $11, (>=28 or <=41) is $16.5, etc...
      // Every 14 days incremental adds $ 5.5. 
      //Hostperiod = ID/14-----> round up to integer
      //Hostprice = hostperiod * 5.5
      // total + tax = hostprice * 1.13


        //string (id<=14) = id* 5.5 * 1.13;
        //string (id>=15) = id* 11 * 1.13;
        //string (id>=28) = id* 16.5 *1.13;



        public int Get(int id)
        {
            return id / 14;
        }
    }
}

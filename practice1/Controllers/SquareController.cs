using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace practice1.Controllers
{
    public class SquareController : ApiController
    {/// <summary>
     /// This method is the square of the input (id)
     /// <example>Get api/square/id</example>
     /// </summary>
     /// <returns>[id * id]</returns>
     ///
        //Get api/Square/2  ----> 4
        //Get api/Square/-2 ----> 4
        //Get api/square/10 ---> 100

        public int get(int id)
        {
            return (id * id);
        }


    }
}

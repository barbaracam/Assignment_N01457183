using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace practice1.Controllers
{
    public class GreetingController : ApiController
    { //post api/greeting  -----> Hello World!
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string post()
        {
            return "Hello World!";
        }
        //Get api/greeting/id-------> Greeting to {id} people!
        //Get api/greeting/3------>Greeting to 3 people!
        //Get Api/Greeting/6 -----> Greeting to 6 people!
        //Get Api/Greeting/0 -----> Greeting to 0 People!
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "Greeting to " + id + " people!" };
        }


    }
}

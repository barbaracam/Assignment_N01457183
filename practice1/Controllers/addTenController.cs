using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace practice1.Controllers
{
    public class AddTenController : ApiController
    { /// <summary>
      /// This method add 10 to the input (id(
      /// <example>Get api/addten/id</example>
      /// </summary>
      /// <returns>[id+10]</returns>
      /// 
        //Get api/addTen/21 ---> 31
        //Get api/addTen/0 ----> 10
        //Get api/AddTen/-9 ---> 1

        public int Get(int id)
    
    {
        return (id + 10);
            
            }
    }
}

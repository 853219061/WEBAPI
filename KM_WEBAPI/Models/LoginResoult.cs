using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KM_WEBAPI.Models
{
    public class LoginResoult : KMResoult
    {


        public int Status { get ; set ; }

        public string Message { get; set ; }


    }
}
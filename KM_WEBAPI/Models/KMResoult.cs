using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KM_WEBAPI.Models
{
    public interface  KMResoult
    {
          int Status { get; set; }

         string Message { get; set; }
    }
}
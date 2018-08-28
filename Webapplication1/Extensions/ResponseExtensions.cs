using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapplication1.Extensions
{
    public  static class ResponseExtensions
    {
        public static void AddApplilcationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            // CORS
            response.Headers.Add("access-control-expose-headers", "Application-Error");
        }
    }
}

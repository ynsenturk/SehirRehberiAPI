using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Helpers
{
    public static class jwtExtension
    {
        public static void AddAplicatonError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Allow-Origin","*");
            response.Headers.Add("Access-Control-Expose-Header", "Application-Error");
        }
    }
}

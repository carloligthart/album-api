using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Album_Api.Services 
{
    public class GreetingService
    {

        public string Greet(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                return "Hello World";
            }
            return "Hello " + name;
        }

    }
}
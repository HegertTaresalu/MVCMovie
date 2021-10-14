using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MvcMovie_TARpe20.Controllers
{

    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int numTimes=1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, Numtimes is {numTimes} ");
        }

        public string Hommik()
        {

            return "hommik";

        }


    }
}

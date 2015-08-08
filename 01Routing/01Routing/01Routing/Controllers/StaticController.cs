using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01Routing.Controllers
{
    [RoutePrefix("")]
    public class StaticController : Controller
    {
        [Route("")]
        // GET: Static
        public string Index()
        {
            return "Jestem w StaticController -> Index";
        }

        [Route("onas")]
        public string About()
        {
            return "O nas";
        }
    }
}
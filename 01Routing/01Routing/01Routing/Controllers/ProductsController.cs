using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01Routing.Controllers
{
    public class ProductsController : Controller
    {
        [Route("products/list")]
        // GET: Products
        public string List()
        {
            return "Jestem w ProductsController -> List";
        }

        [Route("gatunki/{gatunek}")]
        public string Index(string gatunek)
        {
            return gatunek;
        }
    }
}
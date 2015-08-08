using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using _04AJAX.Models;

namespace _04AJAX.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {

        [Route("Index")]
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("SendEmail")]
        public ActionResult SendEmail(MessageDetails message)
        {
            Thread.Sleep(2000);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_PartialEmailConfirmation", message);
            }

            return View("EmailConfirmation",message);
        }
    }
}
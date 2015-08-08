using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model.Models;

namespace Model.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {

        [Route("")]
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

            if (!ModelState.IsValid)
            {
                return View("Index", message);
            }

            if (Request.IsAjaxRequest())
                return PartialView("_PartialEmailConfirmation", message);

            return View("EmailConfirmation", message);
        }
    }
}
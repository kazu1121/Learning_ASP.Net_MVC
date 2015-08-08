using _05Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace _05Model.Controllers
{
    public class HomeController : Controller
    {

        [Route("")]
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
		        return PartialView("_PartialSendConfirmation", message);
	        }

            return View("EmailConfirmation", message);
        }
    }
}
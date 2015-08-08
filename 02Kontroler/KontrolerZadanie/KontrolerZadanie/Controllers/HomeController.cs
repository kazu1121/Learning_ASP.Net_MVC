using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KontrolerZadanie.Logic;
using KontrolerZadanie.Models;

namespace KontrolerZadanie.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {

        [Route("")]
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [HandleError(ExceptionType = typeof(Exception), View = "ErrorView")]
        [Route("SendEmail")]
        public ActionResult SendEmail(Message message)
        {
            return View(message);
        }
    }
}
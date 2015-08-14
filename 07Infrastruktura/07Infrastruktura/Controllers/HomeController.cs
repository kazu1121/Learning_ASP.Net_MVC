using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _07Infrastruktura.DAL;
using _07Infrastruktura.Models;

namespace _07Infrastruktura.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {

        [Route("")]
        public ActionResult Index()
        {
            if(Request.Cookies["authorEmail"] != null)
            {
                var message = new MessageDetails(){authorEmail = Request.Cookies["authorEmail"].Value};

                return View(message);
            }

            return View();
        }


        [Route("SendEmail")]
        [HttpPost]
        public ActionResult SendEmail(MessageDetails message)
        {
            HttpCookie cookie = new HttpCookie("authorEmail", message.authorEmail);
            Response.SetCookie(cookie);

            if (!ModelState.IsValid)
                return View("Index", message);

            if (Request.IsAjaxRequest())
            {
                MessagesContext db = new MessagesContext();
                db.Messages.Add(message);
                db.SaveChanges();

                return PartialView("_PartialEmailConfirmation", message);
            }
            else
            {
                MessagesContext db = new MessagesContext();
                db.Messages.Add(message);
                db.SaveChanges();

                return RedirectToAction("EmailConfirmation", message);
            }



        }


        [HttpGetAttribute]
        public ActionResult EmailConfirmation(MessageDetails message)
        {
            return View("EmailConfirmation", message);
        }
    }
}
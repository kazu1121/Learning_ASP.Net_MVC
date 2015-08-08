using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _06BazyDanych.DAL;
using _06BazyDanych.Models;

namespace _06BazyDanych.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        [Route("")]
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [Route("SendEmail")]
        [HttpPost]
        public ActionResult SendEmail(MessageDetails message)
        {
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

                return View("EmailConfirmation", message);                
            }
        }
    }

}
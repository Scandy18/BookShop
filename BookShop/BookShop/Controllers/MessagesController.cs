using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookShop.Models;

namespace BookShop.Controllers
{
    public class MessagesController : Controller
    {
        private DataMaintain db = new DataMaintain();
        // GET: Messages
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Receive()
        {
            return View();
        }

        public ActionResult Send()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Send([Bind(Include = "Id,Sender,Receiver,Content,Time")] Message msg)
        {
            if (msg == null)
            {
                return HttpNotFound();
            }
            msg.Sender = int.Parse(SessionHelper.Get("id").ToString());
            msg.Time = DateTime.Now;
            db.Message.Add(msg);
            db.SaveChanges();
            return RedirectToAction("Receive");
        }

    }
}
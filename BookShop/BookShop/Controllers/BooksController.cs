using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookShop.Models;

namespace BookShop.Controllers
{
    public class BooksController : Controller
    {
        private DataMaintain db = new DataMaintain();
        // GET: Books
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SellBook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SellBook([Bind(Include = "Id,Seller,BookName,CurPrice,OrgPrice,Catogory,ISBN,Introduce")] Book book)
        {
            if (ModelState.IsValid)
            {
                book.Seller = int.Parse(SessionHelper.Get("id").ToString());
                db.Book.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View("Error");
        }

        public ActionResult Buy(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Book.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            db.Book.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult BookDetail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Book.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
    }
}
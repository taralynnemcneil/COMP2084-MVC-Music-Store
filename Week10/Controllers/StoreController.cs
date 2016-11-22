using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week10.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Store/Browse
        public ActionResult Browse()
        {
            // create aray of hard-coded genres
            var genres = new string[] { "Rock", "Jazz", "Metal" };

            ViewBag.genres = genres;
            return View();
        }

        // GET: /Store/Details
        public String Details(int id)
        {
            string message = "Store.Details, Genre = " + id;
            return message;
        }

    }
}
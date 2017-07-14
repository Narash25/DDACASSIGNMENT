using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DDAC.Models;

namespace Maersk_Line.Controllers
{
    public class BookingsController : Controller
    {
        private Maersk_LineContent db = new Maersk_LineContent();

        // GET: Bookings
        public ActionResult Booking()
        {
            return View(db.Bookings.ToList());
        }
    }
}
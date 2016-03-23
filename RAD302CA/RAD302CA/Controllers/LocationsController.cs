using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RAD302CA.Models;
using RAD302CA.DAL;

namespace RAD302CA.Controllers
{
    public class LocationsController : Controller
    {
        private ILocationRepo repo;
        public LocationsController()
        {
            repo = new LocationRepo(new CoordsContext());
        }
        // GET: Locations
        public ActionResult Index()
        {
            return View(repo.GetAll());
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repo.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

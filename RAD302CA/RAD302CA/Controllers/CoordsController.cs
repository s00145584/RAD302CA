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
    public class CoordsController : Controller
    {
        private ICoordRepo repo;
        public CoordsController()
        {
            repo = new CoordRepo(new CoordsContext());
        }
        // GET: Coords
        public ActionResult Index()
        {
            return View(repo.GetCoords());
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

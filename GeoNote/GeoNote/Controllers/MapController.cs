using GeoNote.DataAccess;
using GeoNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeoNote.Controllers
{
    public class MapController : Controller
    {
        //
        // GET: /Map/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Maps()
        {
            DataAccessor accesss = new DataAccessor();
            List<Image> images = new List<Image>();
            images = accesss.GetImages();

            return View(images);
        }
    }
}

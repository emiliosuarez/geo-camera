namespace GeoNote.Controllers
{
    using GeoNote.DataAccess;
    using GeoNote.Models;
    using PagedList;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Http.Cors;
    using System.Web.Mvc;

    public class ImageController : Controller
    {
        //
        // GET: /Image/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Images(int? page = null)
        {
            int pageNumber = (page ?? 1);

            DataAccessor accesss = new DataAccessor();
            List<Image> images = new List<Image>();
            images = accesss.GetImages();

            IPagedList<Image> imgs = null;

            if (images != null)
            {
                imgs = images.ToPagedList(pageNumber, 30);
            }

            return View(imgs);
        }

        public ActionResult UpdateNotes(Image img)
        {

            return RedirectToAction("Images");
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public ActionResult SaveImage(Image img)
        {
            DataAccessor access = new DataAccessor();
            Image image = img;

            access.SaveImage(image);

            return RedirectToAction("Images");
        }
	}
}
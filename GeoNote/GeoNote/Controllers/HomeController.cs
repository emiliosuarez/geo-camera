namespace GeoNote.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Microsoft.FSharp.Core;
    using Microsoft.FSharp.Collections;
    using PagedList;
    using GeoNote.DataAccess;
    using GeoNote.Models;
    using System.Web.Http.Cors;

    public class HomeController : Controller
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public ActionResult Index()
        {
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
            return View();
        }

        public ActionResult mobile()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What is GeoNote?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "GeoNote Contact.";

            return View();
        }
    }
}
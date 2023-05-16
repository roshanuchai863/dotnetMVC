using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Application.Context;

namespace Web_Application.Controllers
{
    public class HomeController : Controller
    {
        MVCCRUDDBEntities _context = new MVCCRUDDBEntities();

        public ActionResult Index()
        {
            var listofData = _context.Tables.ToList(); ;
            return View(listofData);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create( Table model) {
        _context.Tables.Add(model);
            _context.SaveChanges();
            ViewBag.Massage = "Data insert successful";
            return View();
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS403P1.Controllers
{
    public class ActionController : Controller
    {
        // GET: Action
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Asked(string mish, string prez, string addy, string lang, string climate, string religion, string flag)
        {
            ViewBag.Mission = mish;
            ViewBag.President = prez;
            ViewBag.Address = addy;
            ViewBag.Language = lang;
            ViewBag.Climate = climate;
            ViewBag.Religion = religion;
            ViewBag.Flag = flag;
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IS403P2.DAL;
using IS403P2.Models;

namespace IS403P1.Controllers
{


    public class ActionController : Controller
    {
        private IS403P2Context db = new IS403P2Context();

        // GET: Action
        public ActionResult Index()
        {
            MQU mqu = new MQU();
            mqu.Mission = db.Mission.ToList();

            return View(mqu);
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
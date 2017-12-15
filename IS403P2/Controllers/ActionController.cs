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
            var missionList = new List<Mission>();
            missionList = db.Mission.ToList();
            return View(missionList);
        }

        public ActionResult Asked(int id)
        {
            MQU mqu = new MQU();

            mqu.Mission = db.Mission.Find(id);

            return View(mqu);
        }
    }
}
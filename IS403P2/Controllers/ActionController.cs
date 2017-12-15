using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IS403P2.DAL;
using IS403P2.Models;
using System.IO;

namespace IS403P1.Controllers
{


    public class ActionController : Controller
    {
        IS403P2Context db = new IS403P2Context();

        // GET: Action
        public ActionResult Index()
        {
            var missionList = new List<Mission>();
            missionList = db.Mission.ToList();
            return View(missionList);
        }

        [Authorize]
        public ActionResult Asked(int id)
        {
            MQU mqu = new MQU();

            mqu.MissionQuestions = db.MissionQuestions.Where(i => i.missionID == id).ToList();
            mqu.Mission = db.Mission.Find(id);

            return View(mqu);
        }

        public ActionResult AddImage()
        {
            Mission mish = new Mission();
            return View(mish);
        }
    }
}
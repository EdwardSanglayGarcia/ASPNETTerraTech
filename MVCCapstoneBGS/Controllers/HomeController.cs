using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCapstoneBGS.Controllers
{
    public class HomeController : Controller
    {

        IDataProvider _IDataProvider;
        public HomeController()
        {
            _IDataProvider = new DataProvider();
        }
        public ActionResult Index()
        {

            var LandNumber = _IDataProvider.GetHomeDashboard(1);
            var WaterNumber = _IDataProvider.GetHomeDashboard(2);
            var Users = _IDataProvider.GetDashboard();
            var Progress = _IDataProvider.GetHomeDashboardProgress();

            ViewBag.VBLand = LandNumber;
            ViewBag.VBWater = WaterNumber;
            ViewBag.VBUsers = Users;
            ViewBag.VBProgress = Progress;
            ViewBag.Year = DateTime.Now.Year;
            ViewBag.BUMMY = "<script>alert('hello world');</script>";

            return View();
        }
    }
}
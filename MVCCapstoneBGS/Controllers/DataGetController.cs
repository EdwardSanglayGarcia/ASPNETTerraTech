using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCapstoneBGS.Controllers
{
    public class DataGetController : Controller
    {

        IDataProvider _IDataProvider;
        public DataGetController()
        {
            _IDataProvider = new DataProvider();
        }

        [HttpGet]
        public ActionResult BarChart()
        {

            try
            {
                string tempEnvironmentalConcernCount = string.Empty;
                string tempEnvironmentalConcern = string.Empty;
                //ViewBag.Dashy = _IDataProvider.GetDashboard()
                _IDataProvider.CHART_Display(StoredProcedureEnum.CHART_EnvironmentalConcern.ToString(), DateTime.Now.Year, 0, out tempEnvironmentalConcernCount, out tempEnvironmentalConcern);
                ViewBag.ECCount = tempEnvironmentalConcernCount.Trim();
                ViewBag.ECName = tempEnvironmentalConcern.Trim();
                //  var x = _IDataProvider.GetDashboard();



                _IDataProvider.GetDashboard();
                ViewBag.lols = _IDataProvider.GetDashboard();
                ViewBag.Greetings = "Hello World!";



                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // GET: DataGet
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetUserType()
        {
            //= cmd.GetUserType();
            var data = _IDataProvider.GetUserType();
            JsonResult json = Json(data, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }

        public ActionResult GetCaseReport(int UpdatedStatusID)
        {

            var data = _IDataProvider.GetCaseReport(UpdatedStatusID);
            JsonResult json = Json(data, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }

        public ActionResult GetCaseReportBetweenDates(int UpdatedStatusID, DateTime StartDate, DateTime EndDate)
        {

            var data = _IDataProvider.GetCaseReportBetweenDates(UpdatedStatusID, StartDate, EndDate);
            JsonResult json = Json(data, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }


        public ActionResult GetLWStatus(int UpdatedStatusID, int Year)
        {
            var data = _IDataProvider.GetStatusLWPerYear(UpdatedStatusID, Year);
            JsonResult json = Json(data, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }


        public ActionResult GetCaseReportPhoto(int CaseReportID)
        {

            var data = _IDataProvider.GetCaseReportPhoto(CaseReportID);
            JsonResult json = Json(data, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }


        public ActionResult GetCurrentCaseReport(int UpdatedStatusID)
        {
            var data = _IDataProvider.GetCaseReport(UpdatedStatusID);/*.Where(x=>x.UpdatedStatusDate.Year == DateTime.Now.Year && x.UpdatedStatusID == UpdatedStatusID);*/
            JsonResult json = Json(data, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }

        public ActionResult GetCaseReportPerUser(int UpdatedStatusID, int UserInformationID)
        {
            var data = _IDataProvider.GetCaseReport(UpdatedStatusID).Where(x => x.UserInformationID == UserInformationID);
            JsonResult json = Json(data, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }

        public ActionResult GetAssignedConcerns(int VolunteerID)
        {
            var data = _IDataProvider.GetAssignedConcerns(VolunteerID);
            JsonResult json = Json(data, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }

        public ActionResult GetCurrentCompletedReports(int UpdatedStatusID)
        {
            var data = _IDataProvider.GetCaseReport(UpdatedStatusID).Where(x => x.UpdatedStatusDate.Year == DateTime.Now.Year && x.UpdatedStatusID == UpdatedStatusID);
            JsonResult json = Json(data, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }

        public ActionResult GetUserInformation()
        {
            var data = _IDataProvider.GetUserInformation().Where(x => x.UserTypeID == 2);
            JsonResult json = Json(data, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }
        public ActionResult GetYear()
        {
            var data = _IDataProvider.GetYearDDL();
            JsonResult json = Json(data, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }

        public JsonResult GetVolunteer()
        {
            var data = _IDataProvider.GetVolunteer();
            JsonResult json = Json(data, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }

        public JsonResult GetBanList()
        {
            var data = _IDataProvider.GetBanList();
            JsonResult json = Json(data, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }

        public ActionResult GetUpdatedStatus()
        {
            var data = _IDataProvider.GetUpdatedStatus();
            JsonResult json = Json(data, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }

        public ActionResult GetLeaderboard_Year(int UpdatedStatusID, int Year)
        {
            var data = _IDataProvider.GetLeaderboards_Year(UpdatedStatusID, Year).OrderByDescending(x => x.Points);
            JsonResult json = Json(data, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }



        public ActionResult GetEnvironmentalConcern()
        {
            var data = _IDataProvider.GetEnvironmentalConcern();
            JsonResult json = Json(data, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }

        public ActionResult GetSpecificEnvironmentalConcern(int EnvironmentalConcernID)
        {
            var data = _IDataProvider.GetSpecificEnvironmentalConcern(EnvironmentalConcernID);
            JsonResult json = Json(data, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }
    }
}
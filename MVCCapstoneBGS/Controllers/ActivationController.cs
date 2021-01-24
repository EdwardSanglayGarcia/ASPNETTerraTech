using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCapstoneBGS.Controllers
{
    public class ActivationController : Controller
    {
        IDataProvider _IDataProvider;
        public ActivationController()
        {
            _IDataProvider = new DataProvider();
        }

        public ActionResult Index(string verificationcode)
        {
            string result = "";
            _IDataProvider.Verify_UserInformation(verificationcode);
            result = "<script>Swal.fire({  icon: 'success',  title: 'SUCCESS!',  text: 'Account successfully verified!',  footer: '<a href>Powered by TerraTechPH</a>'})</script>";
            TempData["message"] = result;

            return RedirectToAction("Login", "Entities", TempData["message"]);
        }
    }
}
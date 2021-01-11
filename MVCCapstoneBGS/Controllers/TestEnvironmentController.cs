using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;


namespace MVCCapstoneBGS.Controllers
{
    public class TestEnvironmentController : Controller
    {
        // GET: TestEnvironment
        public ActionResult Index()
        {

            string imgurId = "785030f668c9715";
            string link = string.Empty;
            using (var w = new WebClient())
            {
                string clientID = imgurId;
                w.Headers.Add("Authorization", "Client-ID " + clientID);

                Image myImage = Image.FromFile(Server.MapPath("~/TerraAssets/Photo/Area Report.png"));
                MemoryStream myMemory = new MemoryStream();
                myImage.Save(myMemory, myImage.RawFormat);
                byte[] myImageBytes = myMemory.ToArray();
                string myBase64String = Convert.ToBase64String(myImageBytes);

                var values = new NameValueCollection
            {
                { "image", Convert.ToBase64String(myImageBytes) }
            };

                byte[] response = w.UploadValues("https://api.imgur.com/3/upload.xml", values);

                var responseXml = XDocument.Load(new MemoryStream(response));
                string imageUrl = (string)responseXml.Root.Element("link");
                //Console.WriteLine(XDocument.Load(new MemoryStream(response)));
                //Console.WriteLine("The link is: " + imageUrl);
                ViewBag.ResultLink = imageUrl;
            }

            ////using (Image image = Image.FromFile(@"C:\Users\pc\Desktop\Default.jpg"))
            ////{
            ////    using (MemoryStream m = new MemoryStream())
            ////    {
            ////        image.Save(m, image.RawFormat);
            ////        byte[] imageBytes = m.ToArray();

            ////        // Convert byte[] to Base64 String
            ////        string base64String = Convert.ToBase64String(imageBytes);
            ////    }
            ////}




            return View();
        }
    }
}